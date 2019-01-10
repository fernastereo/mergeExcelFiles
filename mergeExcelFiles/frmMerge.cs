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
            //// TODO: esta línea de código carga datos en la tabla 'excelFilesDataSet.fileDefinition' Puede moverla o quitarla según sea necesario.
            //this.fileDefinitionTableAdapter.Fill(this.excelFilesDataSet.fileDefinition);
            //textBox1.Text = this.excelFilesDataSet.Tables[0].Rows[1][2].ToString();
            //int n = this.excelFilesDataSet.Tables[0].Rows.Count;
            //textBox2.Text = n.ToString();
            //for (int i = 0; i < n; i++)
            //{
            //    MessageBox.Show(this.excelFilesDataSet.Tables[0].Rows[i][2].ToString());
            //}

        }
    }
}
