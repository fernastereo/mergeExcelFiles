using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace mergeExcelFiles
{
    public partial class frmMerge : Form
    {
        public frmMerge()
        {
            InitializeComponent();
        }

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog flb = new FolderBrowserDialog();
            if (flb.ShowDialog() == DialogResult.OK )
            {
                string sPath = flb.SelectedPath;
                int index = sPath.LastIndexOf('\\');
                string folderName = sPath.Substring(index + 1);
                txtProjectPath.Text = sPath;
                txtProjectPrefix.Text = folderName;

                dbAccess DB = new dbAccess(folderName);
                txtMasterFile.Text = DB.masterFile;
            }
        }

        private void frmMerge_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fileDefinitionDataSet.fileDefinition' Puede moverla o quitarla según sea necesario.
            this.fileDefinitionTableAdapter.Fill(this.fileDefinitionDataSet.fileDefinition);
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            /* 
             * 0- id
             * 1- tittle
             * 2- filename
             * 3- initrow
             * 4- endrow
             * 5- status (unbounded)
             */
            int n = fileDefinitionDataSet.Tables[0].Rows.Count;
            int initRow = 0;
            int endRow = 0;
            string fileToProcess = "";
            
            for (int i = 0; i < n; i++)
            {
                fileToProcess = this.fileDefinitionDataSet.Tables[0].Rows[i][2].ToString().Replace(dbAccess.BASE_PREFIX, txtProjectPrefix.Text);
                initRow = (int)this.fileDefinitionDataSet.Tables[0].Rows[i][3];
                endRow = (int)this.fileDefinitionDataSet.Tables[0].Rows[i][4];

                MessageBox.Show($"Tomo el archivo {fileToProcess} y actualizo el maestro Desde la fila {initRow} hasta la fila {endRow} con los codigos que coincidan en ese archivo");
            }
        }

        private static void ReadExcelFile()
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(filePath);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            Excel.Range xlRange = xlWorkSheet.UsedRange;
            int totalRows = xlRange.Rows.Count;
            int totalColumns = xlRange.Columns.Count;

            string firstValue, secondValue;

            for (int rowCount = 1; rowCount <= totalRows; rowCount++)
            {

                firstValue = Convert.ToString((xlRange.Cells[rowCount, 1] as Excel.Range).Text);
                secondValue = Convert.ToString((xlRange.Cells[rowCount, 2] as Excel.Range).Text);

                Console.WriteLine(firstValue + "\t" + secondValue);

            }

            xlWorkBook.Close();
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            
        }
    }
}
