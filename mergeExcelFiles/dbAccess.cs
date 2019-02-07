using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using masterFileExcel = Microsoft.Office.Interop.Excel;
using childFileExcel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace mergeExcelFiles
{
    class dbAccess
    {
        public const string BASE_PREFIX = "XXX";

        private string _prefix;
        private string _masterFile;
        private int _masterFileId;

        public string masterFile {
            get {
                _masterFile = "";
                OleDbDataAdapter dtaMasterfile = new OleDbDataAdapter("select masterfile, quantitycol from configdata where status=1 and id=" + _masterFileId, new OleDbConnection(getConnectionString()));
                DataTable dttMasterFile = new DataTable();
                dtaMasterfile.Fill(dttMasterFile);
                if (dttMasterFile.Rows.Count > 0)
                {
                    string baseFile = dttMasterFile.Rows[0]["masterfile"].ToString().ToUpper();
                    _masterFile = baseFile.Replace(BASE_PREFIX, _prefix);
                }
                return _masterFile;
            }
        }

        private string _quantityCol()
        {
            OleDbDataAdapter dtaQuantityCol = new OleDbDataAdapter("select quantitycol from configdata where status=1 and id=" + _masterFileId, new OleDbConnection(getConnectionString()));
            DataTable dttQuantityCol = new DataTable();
            dtaQuantityCol.Fill(dttQuantityCol);
            if (dttQuantityCol.Rows.Count > 0)
            {
                return dttQuantityCol.Rows[0]["quantitycol"].ToString();
            }

            return "";
        }

        public static string getConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["mergeExcelFiles.Properties.Settings.excelFilesConnectionString"].ConnectionString.ToString();
        }

        public dbAccess(string prefix, int masterFileId)
        {
            _prefix = prefix;
            _masterFileId = masterFileId;
        }

        public dbAccess(int masterFileId)
        {
            _prefix = "";
            _masterFileId = masterFileId;
        }

        public Boolean mergeData(string sPath, string masterFile, DataTable childFiles, string projectPrefix)
        {
            int initRow = 0;
            int endRow = 0;
            string fileToProcess = "";

            //Open master file:
            string filePath = sPath + "\\" + masterFile;
            masterFileExcel.Application xlApp = new masterFileExcel.Application();
            //I Must catch a exception here when the file doesn't exits in folder------>>>>
            masterFileExcel.Workbook xlWorkBook = xlApp.Workbooks.Open(filePath);
            masterFileExcel.Worksheet xlWorkSheet = (masterFileExcel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            masterFileExcel.Range xlRange = xlWorkSheet.UsedRange;

            //for each child file in gridView:
            int n = childFiles.Rows.Count;
            string searchCode;
            string workSheet;            

            for (int i = 0; i < n; i++)
            {
                //Get the child filename and replace the XXX by project prefix
                fileToProcess = childFiles.Rows[i]["filename"].ToString().ToUpper().Replace(BASE_PREFIX, projectPrefix);
                //get the rows for the master file
                initRow = (int)childFiles.Rows[i]["initrow"];
                endRow = (int)childFiles.Rows[i]["endrow"];

                workSheet = childFiles.Rows[i]["worksheet"].ToString(); //<<-- Here is where I assign the worksheet
                workSheet = workSheet.Substring(0, workSheet.Length - 1);
                string searchColChild = (string)childFiles.Rows[i]["searchcol"];
                string quantityColChild = (string)childFiles.Rows[i]["quantitycol"];

                //get the fullpath for the child file
                filePath = sPath + "\\" + fileToProcess + ".xls";
                //Open the child file:
                childFileExcel.Application xlAppChild = new childFileExcel.Application();
                childFileExcel.Workbook xlWorkBookChild = xlAppChild.Workbooks.Open(filePath);
                childFileExcel.Worksheet xlWorkSheetChild = (childFileExcel.Worksheet)xlWorkBookChild.Worksheets[workSheet];
                //childFileExcel.Range xlRangeChild = xlWorkSheetChild.UsedRange; :original line
                childFileExcel.Range xlRangeChild = xlWorkSheetChild.Columns[searchColChild];

                string qCol = _quantityCol();

                //for each record from init to end in masterfile
                //Console.WriteLine($"Procesando el archivo {fileToProcess} - Hoja: {workSheet}");
                for (int rowCount = initRow; rowCount <= endRow; rowCount++)
                {
                    //get the code we will look for in master file
                    searchCode = Convert.ToString((xlRange.Cells[rowCount, 1] as masterFileExcel.Range).Text);

                    if (!string.IsNullOrEmpty(searchCode) && searchCode.Length > 1)
                    {
                        // search searchString in the range, if find result, return a range
                        childFileExcel.Range resultRange = xlRangeChild.Find(
                            What: searchCode,
                            LookIn: childFileExcel.XlFindLookIn.xlValues,
                            LookAt: childFileExcel.XlLookAt.xlPart,
                            SearchOrder: childFileExcel.XlSearchOrder.xlByRows,
                            SearchDirection: childFileExcel.XlSearchDirection.xlNext
                        );
                        if (resultRange != null)
                        {
                            int rowResult = resultRange.Row;                            
                            
                            string childValue = Convert.ToString((xlWorkSheetChild.Cells[rowResult, quantityColChild] as masterFileExcel.Range).Text);
                            xlWorkSheet.Cells[rowCount, qCol] = childValue;
                            //searchCode = string.Concat("***** OK! ***** ", searchCode, " En la fila: ", rowResult);
                        }
                        else
                        {
                            xlWorkSheet.Cells[rowCount, qCol] = "";
                            //searchCode = string.Concat("-- Not Found-- ", searchCode);
                        }
                        //Console.WriteLine(searchCode);
                    }
                }

                //close the child file:
                xlWorkBookChild.Close(false);
                xlAppChild.Quit();

                Marshal.ReleaseComObject(xlWorkSheetChild);
                Marshal.ReleaseComObject(xlWorkBookChild);
                Marshal.ReleaseComObject(xlAppChild);
            }
            xlWorkBook.Save();

            xlWorkBook.Close(true);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            killExcel();

            return true;
        }

        private void killExcel()
        {
            foreach (Process proceso in Process.GetProcesses())
            {
                if (proceso.ProcessName == "EXCEL")
                {
                    proceso.Kill();
                }
            }
        }

        public static DataTable getFileDefinition(int masterFileId)
        {
            OleDbConnection strConnection = new OleDbConnection(dbAccess.getConnectionString());
            OleDbCommand strQuery = new OleDbCommand("select f.tittle, f.filename, (select count(*) from worksheet w where w.filedefinition_id = f.id) as worksheets, f.initrow, f.endrow from filedefinition f where f.master_id=@master_id order by f.id", strConnection);
            strQuery.Parameters.AddWithValue("@master_id", masterFileId);
            OleDbDataAdapter dadFileDefinition = new OleDbDataAdapter(strQuery);
            DataTable dttFileDefinition = new DataTable();
            dadFileDefinition.Fill(dttFileDefinition);
            return dttFileDefinition;
        }
    }
}
