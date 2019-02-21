namespace mergeExcelFiles
{
    partial class frmMerge
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMerge));
            this.imlIcons = new System.Windows.Forms.ImageList(this.components);
            this.configDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excelFilesDataSet = new mergeExcelFiles.excelFilesDataSet();
            this.configDataTableAdapter = new mergeExcelFiles.excelFilesDataSetTableAdapters.configDataTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cboMasterFile = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkSendEmail = new System.Windows.Forms.CheckBox();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.txtMasterFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjectPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pgbMergeFiles = new System.Windows.Forms.ProgressBar();
            this.dgvFileDefinition = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tittle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worksheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateMailSettings = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.configDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelFilesDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileDefinition)).BeginInit();
            this.SuspendLayout();
            // 
            // imlIcons
            // 
            this.imlIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcons.ImageStream")));
            this.imlIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlIcons.Images.SetKeyName(0, "icons8-save-50.png");
            this.imlIcons.Images.SetKeyName(1, "folder-open-shape_icon-icons.com_56975.png");
            this.imlIcons.Images.SetKeyName(2, "1486348532-music-play-pause-control-go-arrow_80458.png");
            this.imlIcons.Images.SetKeyName(3, "play-button_icon-icons.com_65316.png");
            this.imlIcons.Images.SetKeyName(4, "start-button_icon-icons.com_53873.png");
            this.imlIcons.Images.SetKeyName(5, "3706872-control-music-play-play-music-play-sound-start_108717.png");
            this.imlIcons.Images.SetKeyName(6, "Start_icon-icons.com_55807.png");
            // 
            // configDataBindingSource
            // 
            this.configDataBindingSource.DataMember = "configData";
            this.configDataBindingSource.DataSource = this.excelFilesDataSet;
            // 
            // excelFilesDataSet
            // 
            this.excelFilesDataSet.DataSetName = "excelFilesDataSet";
            this.excelFilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configDataTableAdapter
            // 
            this.configDataTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 281);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.lblProgress);
            this.tabPage1.Controls.Add(this.pgbMergeFiles);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cboMasterFile);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consolidar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dgvFileDefinition);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parámetros Archivos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtSender);
            this.tabPage3.Controls.Add(this.txtPassword);
            this.tabPage3.Controls.Add(this.txtUser);
            this.tabPage3.Controls.Add(this.txtPort);
            this.tabPage3.Controls.Add(this.txtHost);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnUpdateMailSettings);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(667, 255);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Parámetros Correo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cboMasterFile
            // 
            this.cboMasterFile.DataSource = this.configDataBindingSource;
            this.cboMasterFile.DisplayMember = "masterfile";
            this.cboMasterFile.FormattingEnabled = true;
            this.cboMasterFile.Location = new System.Drawing.Point(186, 17);
            this.cboMasterFile.Name = "cboMasterFile";
            this.cboMasterFile.Size = new System.Drawing.Size(218, 21);
            this.cboMasterFile.TabIndex = 5;
            this.cboMasterFile.ValueMember = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seleccione Maestro a Consolidar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.chkSendEmail);
            this.groupBox1.Controls.Add(this.btnStartTask);
            this.groupBox1.Controls.Add(this.txtMasterFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProjectPrefix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnOpenPath);
            this.groupBox1.Controls.Add(this.txtProjectPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carpeta Proyecto";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(245, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // chkSendEmail
            // 
            this.chkSendEmail.AutoSize = true;
            this.chkSendEmail.Location = new System.Drawing.Point(19, 96);
            this.chkSendEmail.Name = "chkSendEmail";
            this.chkSendEmail.Size = new System.Drawing.Size(227, 17);
            this.chkSendEmail.TabIndex = 8;
            this.chkSendEmail.Text = "Enviar por correo al finalizar al destinatario:";
            this.chkSendEmail.UseVisualStyleBackColor = true;
            // 
            // btnStartTask
            // 
            this.btnStartTask.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartTask.ImageIndex = 4;
            this.btnStartTask.ImageList = this.imlIcons;
            this.btnStartTask.Location = new System.Drawing.Point(482, 89);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(127, 27);
            this.btnStartTask.TabIndex = 7;
            this.btnStartTask.Text = "Consolidar Datos";
            this.btnStartTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartTask.UseVisualStyleBackColor = true;
            // 
            // txtMasterFile
            // 
            this.txtMasterFile.Location = new System.Drawing.Point(282, 60);
            this.txtMasterFile.Name = "txtMasterFile";
            this.txtMasterFile.Size = new System.Drawing.Size(184, 20);
            this.txtMasterFile.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Archivo Maestro:";
            // 
            // txtProjectPrefix
            // 
            this.txtProjectPrefix.Location = new System.Drawing.Point(99, 60);
            this.txtProjectPrefix.Name = "txtProjectPrefix";
            this.txtProjectPrefix.Size = new System.Drawing.Size(63, 20);
            this.txtProjectPrefix.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prefijo Proyecto:";
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.ImageKey = "folder-open-shape_icon-icons.com_56975.png";
            this.btnOpenPath.ImageList = this.imlIcons;
            this.btnOpenPath.Location = new System.Drawing.Point(582, 22);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(27, 25);
            this.btnOpenPath.TabIndex = 2;
            this.btnOpenPath.UseVisualStyleBackColor = true;
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Location = new System.Drawing.Point(99, 25);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(477, 20);
            this.txtProjectPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta Carpeta:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(538, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(18, 224);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Visible = false;
            // 
            // pgbMergeFiles
            // 
            this.pgbMergeFiles.Location = new System.Drawing.Point(18, 190);
            this.pgbMergeFiles.Name = "pgbMergeFiles";
            this.pgbMergeFiles.Size = new System.Drawing.Size(628, 23);
            this.pgbMergeFiles.TabIndex = 7;
            this.pgbMergeFiles.Visible = false;
            // 
            // dgvFileDefinition
            // 
            this.dgvFileDefinition.AllowUserToAddRows = false;
            this.dgvFileDefinition.AllowUserToDeleteRows = false;
            this.dgvFileDefinition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileDefinition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tittle,
            this.filename,
            this.worksheet,
            this.initrow,
            this.endrow});
            this.dgvFileDefinition.Location = new System.Drawing.Point(18, 19);
            this.dgvFileDefinition.Name = "dgvFileDefinition";
            this.dgvFileDefinition.ReadOnly = true;
            this.dgvFileDefinition.Size = new System.Drawing.Size(628, 188);
            this.dgvFileDefinition.TabIndex = 2;
            this.dgvFileDefinition.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // tittle
            // 
            this.tittle.DataPropertyName = "tittle";
            this.tittle.HeaderText = "Descripción";
            this.tittle.Name = "tittle";
            this.tittle.ReadOnly = true;
            // 
            // filename
            // 
            this.filename.DataPropertyName = "filename";
            this.filename.HeaderText = "Archivo";
            this.filename.Name = "filename";
            this.filename.ReadOnly = true;
            // 
            // worksheet
            // 
            this.worksheet.DataPropertyName = "worksheets";
            this.worksheet.HeaderText = "Hojas";
            this.worksheet.Name = "worksheet";
            this.worksheet.ReadOnly = true;
            // 
            // initrow
            // 
            this.initrow.DataPropertyName = "startrow";
            this.initrow.HeaderText = "Inicio";
            this.initrow.Name = "initrow";
            this.initrow.ReadOnly = true;
            // 
            // endrow
            // 
            this.endrow.DataPropertyName = "endrow";
            this.endrow.HeaderText = "Final";
            this.endrow.Name = "endrow";
            this.endrow.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Servidor Correo Saliente:";
            // 
            // btnUpdateMailSettings
            // 
            this.btnUpdateMailSettings.Location = new System.Drawing.Point(536, 214);
            this.btnUpdateMailSettings.Name = "btnUpdateMailSettings";
            this.btnUpdateMailSettings.Size = new System.Drawing.Size(108, 23);
            this.btnUpdateMailSettings.TabIndex = 10;
            this.btnUpdateMailSettings.Text = "A&ctualizar";
            this.btnUpdateMailSettings.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Puerto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nombre Remitente";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(147, 23);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(224, 20);
            this.txtHost.TabIndex = 15;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(147, 55);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(45, 20);
            this.txtPort.TabIndex = 16;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(147, 85);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(224, 20);
            this.txtUser.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(147, 114);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(224, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(147, 144);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(224, 20);
            this.txtSender.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "A&ctualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 305);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMerge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mergeExcelFiles";
            this.Load += new System.EventHandler(this.frmMerge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.configDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelFilesDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileDefinition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imlIcons;
        private excelFilesDataSet excelFilesDataSet;
        private System.Windows.Forms.BindingSource configDataBindingSource;
        private excelFilesDataSetTableAdapters.configDataTableAdapter configDataTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar pgbMergeFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chkSendEmail;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.TextBox txtMasterFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjectPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMasterFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvFileDefinition;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn worksheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn initrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn endrow;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateMailSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
    }
}

