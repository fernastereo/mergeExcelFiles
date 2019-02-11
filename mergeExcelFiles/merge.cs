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
    class merge
    {
        public const string BASE_PREFIX = "XXX";

        private int _final;          // Valor de finalización

        private string _prefix;
        private string _masterFile;
        private int _masterFileId;
        private DataTable _childFiles;

        private string _errMsg;

        public string errMsg
        {
            get { return _errMsg; }
        }

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

        public dbAccess(DataTable childFiles, int masterFileId)
        {
            _prefix = "";
            _masterFileId = masterFileId;
            _childFiles = childFiles;
            _final = _childFiles.Rows.Count;
        }

        public delegate void cambioPosHandler(object o, PosicEventArgs ev);

        public event cambioPosHandler cambioPosic;

        protected virtual void onCambioPosic(PosicEventArgs e)
        {
            if (cambioPosic != null)
                cambioPosic(this, e); //invocacion del delegado
        }

        public int Final
        {
            get { return _final; }
        }

        public void mergeData(string sPath, string masterFile, string projectPrefix)
        {
            int fileDefinitionId = 0;
            int startRow = 0;
            int endRow = 0;
            string fileToProcess = "";
            
            //Open master file:
            string filePath = sPath + "\\" + masterFile;
            masterFileExcel.Application xlApp = new masterFileExcel.Application();

            //I Must catch a exception here when the file doesn't exits in folder------>>>>
            if (!System.IO.File.Exists(filePath))
            {
                _errMsg = "El archivo maestro no existe en la ruta especificada";
                return;
            }
            masterFileExcel.Workbook xlWorkBook = xlApp.Workbooks.Open(filePath);
            masterFileExcel.Worksheet xlWorkSheet = (masterFileExcel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            masterFileExcel.Range xlRange = xlWorkSheet.UsedRange;

            //for each child file in gridView:
            int n = _final;
            string searchCode;
            string workSheet;

            for (int i = 0; i < n; i++)
            {
                onCambioPosic(new PosicEventArgs(i));
                //Get the child filename and replace the XXX by project prefix
                fileToProcess = _childFiles.Rows[i]["filename"].ToString().ToUpper().Replace(BASE_PREFIX, projectPrefix);
                //get the rows for the master file
                fileDefinitionId = (int)_childFiles.Rows[i]["id"];
                startRow = (int)_childFiles.Rows[i]["startrow"];
                endRow = (int)_childFiles.Rows[i]["endrow"];
                string qCol = _quantityCol(); //quantityCol for the master file

                //First blank the cells are going to be updated
                blankCells(startRow, endRow, qCol, xlWorkSheet);

                //Before get the worksheets we must open the file, so get the fullpath for the child file
                filePath = sPath + "\\" + fileToProcess + ".xls";
                //Open the child file:
                childFileExcel.Application xlAppChild = new childFileExcel.Application();
                childFileExcel.Workbook xlWorkBookChild = xlAppChild.Workbooks.Open(filePath);

                //Here I get all the sheets for every child file and process it
                DataTable dttWorkSheets = getWorkSheets(fileDefinitionId);

                //Process each worksheet in xlsFile
                foreach (DataRow dtrWorkSheet in dttWorkSheets.Rows)
                {
                    workSheet = dtrWorkSheet["worksheet"].ToString(); //<<-- Here is where I assign the worksheet
                    workSheet = workSheet.Substring(0, workSheet.Length - 1);
                    string searchColChild = dtrWorkSheet["searchcol"].ToString();
                    string quantityColChild = dtrWorkSheet["quantitycol"].ToString();

                    Console.WriteLine($"Archivo {fileToProcess} - Hoja: {workSheet}");

                    childFileExcel.Worksheet xlWorkSheetChild = (childFileExcel.Worksheet)xlWorkBookChild.Worksheets[workSheet];
                    //childFileExcel.Range xlRangeChild = xlWorkSheetChild.UsedRange; :original line
                    childFileExcel.Range xlRangeChild = xlWorkSheetChild.Columns[searchColChild];

                    //for each record from init to end in masterfile
                    for (int rowCount = startRow; rowCount <= endRow; rowCount++)
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
                            }
                        }
                    }
                    Marshal.ReleaseComObject(xlWorkSheetChild);
                }
                //close the child file:
                xlWorkBookChild.Close(false);
                xlAppChild.Quit();

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
            _errMsg = "Proceso finalizado satisfactoriamente";
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
            OleDbConnection strConnection = new OleDbConnection(getConnectionString());
            OleDbCommand strQuery = new OleDbCommand("select f.id, f.tittle, f.filename, (select count(*) from worksheet w where w.filedefinition_id = f.id) as worksheets, f.startrow, f.endrow from filedefinition f where f.master_id=@master_id order by f.id", strConnection);
            strQuery.Parameters.AddWithValue("@master_id", masterFileId);
            OleDbDataAdapter dadFileDefinition = new OleDbDataAdapter(strQuery);
            DataTable dttFileDefinition = new DataTable();
            dadFileDefinition.Fill(dttFileDefinition);
            return dttFileDefinition;
        }

        private static DataTable getWorkSheets(int fileDefinitionId)
        {
            OleDbConnection strConnection = new OleDbConnection(getConnectionString());
            OleDbCommand strQuery = new OleDbCommand("select worksheet, quantitycol, searchcol from worksheet where filedefinition_id=@filedefinitionid", strConnection);
            strQuery.Parameters.AddWithValue("@filedefinitionid", fileDefinitionId);
            OleDbDataAdapter dadWorkSheets = new OleDbDataAdapter(strQuery);
            DataTable dttWorkSheets = new DataTable();
            dadWorkSheets.Fill(dttWorkSheets);
            return dttWorkSheets;
        }

        private void blankCells(int start, int end, string qCol, masterFileExcel.Worksheet workSheet)
        {
            for (int rowCount = start; rowCount <= end; rowCount++)
            {
                workSheet.Cells[rowCount, qCol] = "";
            }
        }
    }
}
