﻿using System;
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

        public string masterFile {
            get {
                _masterFile = "";
                OleDbDataAdapter dtaMasterfile = new OleDbDataAdapter("select masterfile from configdata where status=1", new OleDbConnection(getConnectionString()));
                DataTable dttMasterFile = new DataTable();
                dtaMasterfile.Fill(dttMasterFile);
                if (dttMasterFile.Rows.Count > 0)
                {
                    string baseFile = dttMasterFile.Rows[0]["masterfile"].ToString();
                    _masterFile = baseFile.Replace(BASE_PREFIX, _prefix);
                }
                return _masterFile;
            }
        }

        public static string getConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["mergeExcelFiles.Properties.Settings.excelFilesConnectionString"].ConnectionString.ToString();
        }

        public dbAccess(string prefix)
        {
            _prefix = prefix;
        }

        public dbAccess()
        {
            _prefix = "";
        }

        //private List<string> getChildFiles()
        //{
        //    List<String> fileNames = new List<String>();

        //    using (OleDbConnection connection = new OleDbConnection(getConnectionString()))
        //    {
        //        connection.Open();
        //        string query = "select filename from filedefinition";
        //        using (OleDbCommand command = new OleDbCommand(query, connection))
        //        {
        //            using (OleDbDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    fileNames.Add(reader.GetString(0));
        //                }
        //            }
        //        }
        //    }
        //    return fileNames;
        //}

        public Boolean mergeData(string sPath, string masterFile, DataSet childFiles, string projectPrefix)
        {
            //int n = childFiles.Tables[0].Rows.Count;
            int initRow = 0;
            int endRow = 0;
            string fileToProcess = "";

            //for (int i = 0; i < n; i++)
            //{
            //    fileToProcess = childFiles.Tables[0].Rows[i][2].ToString().Replace(BASE_PREFIX, projectPrefix);
            //    initRow = (int)childFiles.Tables[0].Rows[i][3];
            //    endRow = (int)childFiles.Tables[0].Rows[i][4];

            //    Console.WriteLine($"Tomo el archivo {fileToProcess} y actualizo el maestro Desde la fila {initRow} hasta la fila {endRow} con los codigos que coincidan en ese archivo");
            //}

            //Open master file:
            string filePath = sPath + "\\" + masterFile;
            masterFileExcel.Application xlApp = new masterFileExcel.Application();
            masterFileExcel.Workbook xlWorkBook = xlApp.Workbooks.Open(filePath);
            masterFileExcel.Worksheet xlWorkSheet = (masterFileExcel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            masterFileExcel.Range xlRange = xlWorkSheet.UsedRange;
            //int totalRows = xlRange.Rows.Count;
            //int totalColumns = xlRange.Columns.Count;

            //for each child file in gridView:
            int n = childFiles.Tables[0].Rows.Count;
            string searchCode;
            string workSheet;
            for (int i = 0; i < n; i++)
            {
                //Get the child filename and replace the XXX by project prefix
                fileToProcess = childFiles.Tables[0].Rows[i]["filename"].ToString().Replace(BASE_PREFIX, projectPrefix);
                workSheet = childFiles.Tables[0].Rows[i]["worksheet"].ToString();
                workSheet = workSheet.Substring(0, workSheet.Length - 1);
                //get the rows for the master file
                initRow = (int)childFiles.Tables[0].Rows[i]["initrow"] - 1;
                endRow = (int)childFiles.Tables[0].Rows[i]["endrow"] - 1;
                //get the fullpath for the child file
                filePath = sPath + "\\" + fileToProcess + ".xls";
                //Open the child file:
                childFileExcel.Application xlAppChild = new childFileExcel.Application();
                childFileExcel.Workbook xlWorkBookChild = xlAppChild.Workbooks.Open(filePath);
                childFileExcel.Worksheet xlWorkSheetChild = (childFileExcel.Worksheet)xlWorkBookChild.Worksheets[workSheet];
                //childFileExcel.Range xlRangeChild = xlWorkSheetChild.UsedRange; :original line
                childFileExcel.Range xlRangeChild = xlWorkSheetChild.Columns["A:B"];

                //xlRangeChild.Find()
                //for each record from init to end in masterfile
                Console.WriteLine($"Procesando el archivo {fileToProcess} - Hoja: {workSheet}");
                for (int rowCount = initRow; rowCount <= endRow; rowCount++)
                {   
                    //get the code we will look for in master file
                    searchCode = Convert.ToString((xlRange.Cells[rowCount, 1] as masterFileExcel.Range).Text);

                    if (!string.IsNullOrEmpty(searchCode))
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
                            searchCode = string.Concat("***** OK! ***** ", searchCode, " En la fila: ", resultRange.Row);
                        }
                        else
                        {
                            searchCode = string.Concat("-- Not Found-- ", searchCode);
                        }

                        Console.WriteLine(searchCode);
                    }
                }

                //close the child file:
                xlWorkBookChild.Close(false);
                xlAppChild.Quit();

                Marshal.ReleaseComObject(xlWorkSheetChild);
                Marshal.ReleaseComObject(xlWorkBookChild);
                Marshal.ReleaseComObject(xlAppChild);
            }

            xlWorkBook.Close(false);
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
    }
}
