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
            flb.SelectedPath = "C:\\Users\\Fernast\\Documents\\Proyectos\\Upwork\\Marga Company\\DER";
            
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
            mailSettings.getMailconfig();
            txtHost.Text = mailSettings.Host;
            numPort.Value = mailSettings.Port;
            chkEnableSSL.Checked = mailSettings.enableSSL;
            txtUser.Text = mailSettings.User;
            txtPassword.Text = mailSettings.Password;
            txtSender.Text = mailSettings.Sender;
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
                    dbConfig mailSettings = new dbConfig();
                    mailSettings.getMailconfig();
                    emailAdmin eMail = new emailAdmin(mailSettings.Host, mailSettings.Port, mailSettings.User, mailSettings.Password, mailSettings.Sender, mailSettings.enableSSL);
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

        private void fncSearchForWorksheets() {
            //This function is for identify each worksheet in the excel file 
            //before start to process it.
            //This function must be deleted.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnUpdateMailSettings_Click(object sender, EventArgs e)
        {
            dbConfig mailSettings = new dbConfig();
            mailSettings.Host = txtHost.Text;
            mailSettings.Port = (int)numPort.Value;
            mailSettings.enableSSL = chkEnableSSL.Checked;
            mailSettings.User = txtUser.Text.ToLower();
            mailSettings.Password = txtPassword.Text;
            mailSettings.Sender = txtSender.Text.ToUpper();

            if (!mailSettings.saveMailSettings())
            {
                MessageBox.Show(mailSettings.errMsg);
            }
        }
    }
}
