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
using System.Net.Mail;

namespace mergeExcelFiles
{
    public partial class frmMerge : Form
    {
        private DataTable _dttExcelFiles;
        private const string _MESSSAGE = "Enviando archivo consolidado por correo electrónico";

        public frmMerge()
        {
            InitializeComponent();
        }

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog flb = new FolderBrowserDialog();

            //Quitar la siguiente linea antes de entregar
            flb.SelectedPath = "C:\\Users\\Fernast\\Documents\\Proyectos\\Upwork\\Marga Company\\NUE";
            txtEmail.Text = "info@css-sas.com";
            //*******************************************
            if (flb.ShowDialog() == DialogResult.OK)
            {
                string sPath = flb.SelectedPath;
                int index = sPath.LastIndexOf('\\');
                string folderName = sPath.Substring(index + 1);
                txtProjectPath.Text = sPath;
                txtProjectPrefix.Text = folderName;

                int master_id = (int)cboMasterFile.SelectedValue;
                merge task = new merge(folderName, master_id);
                txtMasterFile.Text = task.masterFile;
            }
        }

        private void frmMerge_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'excelFilesDataSet.configData' Puede moverla o quitarla según sea necesario.
            this.configDataTableAdapter.Fill(this.excelFilesDataSet.configData);

            //retrieve email settings
            dbConfig mailSettings = new dbConfig();
            txtHost.Text = mailSettings.Host;
            txtPort.Text = mailSettings.Port.ToString();
            chkEnableSSL.Checked = mailSettings.enableSSL;
            txtUser.Text = mailSettings.User;
            txtPassword.Text = mailSettings.Password;
            
            
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            pgbMergeFiles.Visible = true;
            lblProgress.Visible = true;
            btnStartTask.Enabled = false;
            btnExit.Enabled = false;
            int master_id = (int)cboMasterFile.SelectedValue;
            merge task = new merge(_dttExcelFiles, master_id);
            pgbMergeFiles.Minimum = 0;
            pgbMergeFiles.Maximum = task.Final;
            task.cambioPosic += new merge.cambioPosHandler(DB_cambioPosic);
            if (task.mergeData(txtProjectPath.Text, txtMasterFile.Text, txtProjectPrefix.Text))
            {
                //if task runs properly then send the email if it is checked
                if (chkSendEmail.Checked)
                {
                    dbConfig mailConfig = new dbConfig();
                    emailAdmin eMail = new emailAdmin(mailConfig.Host, mailConfig.Port, mailConfig.User, mailConfig.Password, mailConfig.enableSSL);
                    string fileAttached = this.txtProjectPath.Text + '\\' + this.txtMasterFile.Text;
                    eMail.sendEmail(this.txtEmail.Text, this.txtMasterFile.Text, _MESSSAGE, fileAttached);
                }
            }
            //Show the errMsg anyway
            MessageBox.Show(task.errMsg);
            pgbMergeFiles.Visible = false;
            lblProgress.Visible = false;
            btnStartTask.Enabled = true;
            btnExit.Enabled = true;
        }

        private void DB_cambioPosic(object o, PosicEventArgs ev)
        {
            pgbMergeFiles.Value = ev.posic;
            lblProgress.Text = $"Compilando Archivo {_dttExcelFiles.Rows[ev.posic - 1]["filename"]} - ({ev.posic} de {pgbMergeFiles.Maximum})";
        }

        private void cboMasterFile_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int master_id = (int)cboMasterFile.SelectedValue;
            _dttExcelFiles = merge.getFileDefinition(master_id);
            dgvFileDefinition.DataSource = _dttExcelFiles;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
