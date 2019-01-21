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
        private DataTable _dttExcelFiles;

        public frmMerge()
        {
            InitializeComponent();
        }

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog flb = new FolderBrowserDialog();
            if (flb.ShowDialog() == DialogResult.OK)
            {
                string sPath = flb.SelectedPath;
                int index = sPath.LastIndexOf('\\');
                string folderName = sPath.Substring(index + 1);
                txtProjectPath.Text = sPath;
                txtProjectPrefix.Text = folderName;

                int master_id = (int)cboMasterFile.SelectedValue;
                dbAccess DB = new dbAccess(folderName, master_id);
                txtMasterFile.Text = DB.masterFile;
            }
        }

        private void frmMerge_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'excelFilesDataSet.configData' Puede moverla o quitarla según sea necesario.
            this.configDataTableAdapter.Fill(this.excelFilesDataSet.configData);
            // TODO: esta línea de código carga datos en la tabla 'excelFilesDataSet.configData' Puede moverla o quitarla según sea necesario.
            //this.configDataTableAdapter.Fill(this.excelFilesDataSet.configData);
            // TODO: esta línea de código carga datos en la tabla 'fileDefinitionDataSet.fileDefinition' Puede moverla o quitarla según sea necesario.
            //this.fileDefinitionTableAdapter.Fill(this.fileDefinitionDataSet.fileDefinition);
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            dbAccess DB = new dbAccess();
            //Boolean result = DB.mergeData(txtProjectPath.Text, txtMasterFile.Text, fileDefinitionDataSet, txtProjectPrefix.Text);

            //MessageBox.Show(result.ToString());
        }

        private void cboMasterFile_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int master_id = (int)cboMasterFile.SelectedValue;
            _dttExcelFiles = dbAccess.getFileDefinition(master_id);
            dgvFileDefinition.DataSource = _dttExcelFiles;
        }
    }
}
