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

            //Quitar la siguiente linea antes de entregar
            flb.SelectedPath = "C:\\Users\\Fernast\\Documents\\Proyectos\\Upwork\\Marga Company\\NUE";
            //*******************************************
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
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            int master_id = (int)cboMasterFile.SelectedValue;
            dbAccess DB = new dbAccess(_dttExcelFiles, master_id);
            pgbMergeFiles.Minimum = 0;
            pgbMergeFiles.Maximum = DB.Final;
            DB.cambioPosic += new dbAccess.cambioPosHandler(DB_cambioPosic);
            DB.mergeData(txtProjectPath.Text, txtMasterFile.Text, txtProjectPrefix.Text);
            MessageBox.Show("Proceso finalizado");
        }

        private void DB_cambioPosic(object o, PosicEventArgs ev)
        {
            pgbMergeFiles.Value = ev.posic;
        }

        private void cboMasterFile_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int master_id = (int)cboMasterFile.SelectedValue;
            _dttExcelFiles = dbAccess.getFileDefinition(master_id);
            dgvFileDefinition.DataSource = _dttExcelFiles;
        }
    }
}
