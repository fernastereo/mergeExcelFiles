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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.imlIcons = new System.Windows.Forms.ImageList(this.components);
            this.txtMasterFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjectPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFileDefinition = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tittle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worksheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMasterFile = new System.Windows.Forms.ComboBox();
            this.configDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excelFilesDataSet = new mergeExcelFiles.excelFilesDataSet();
            this.configDataTableAdapter = new mergeExcelFiles.excelFilesDataSetTableAdapters.configDataTableAdapter();
            this.pgbMergeFiles = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileDefinition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelFilesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartTask);
            this.groupBox1.Controls.Add(this.txtMasterFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProjectPrefix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnOpenPath);
            this.groupBox1.Controls.Add(this.txtProjectPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carpeta Proyecto";
            // 
            // btnStartTask
            // 
            this.btnStartTask.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartTask.ImageIndex = 4;
            this.btnStartTask.ImageList = this.imlIcons;
            this.btnStartTask.Location = new System.Drawing.Point(482, 56);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(127, 27);
            this.btnStartTask.TabIndex = 7;
            this.btnStartTask.Text = "Consolidar Datos";
            this.btnStartTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartTask.UseVisualStyleBackColor = true;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
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
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
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
            this.dgvFileDefinition.Location = new System.Drawing.Point(12, 258);
            this.dgvFileDefinition.Name = "dgvFileDefinition";
            this.dgvFileDefinition.ReadOnly = true;
            this.dgvFileDefinition.Size = new System.Drawing.Size(628, 264);
            this.dgvFileDefinition.TabIndex = 1;
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
            this.initrow.DataPropertyName = "initrow";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seleccione Maestro a Consolidar:";
            // 
            // cboMasterFile
            // 
            this.cboMasterFile.DataSource = this.configDataBindingSource;
            this.cboMasterFile.DisplayMember = "masterfile";
            this.cboMasterFile.FormattingEnabled = true;
            this.cboMasterFile.Location = new System.Drawing.Point(183, 17);
            this.cboMasterFile.Name = "cboMasterFile";
            this.cboMasterFile.Size = new System.Drawing.Size(218, 21);
            this.cboMasterFile.TabIndex = 3;
            this.cboMasterFile.ValueMember = "id";
            this.cboMasterFile.SelectionChangeCommitted += new System.EventHandler(this.cboMasterFile_SelectionChangeCommitted);
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
            // pgbMergeFiles
            // 
            this.pgbMergeFiles.Location = new System.Drawing.Point(12, 165);
            this.pgbMergeFiles.Name = "pgbMergeFiles";
            this.pgbMergeFiles.Size = new System.Drawing.Size(628, 23);
            this.pgbMergeFiles.TabIndex = 4;
            this.pgbMergeFiles.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(12, 195);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(532, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 235);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pgbMergeFiles);
            this.Controls.Add(this.cboMasterFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvFileDefinition);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMerge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mergeExcelFiles";
            this.Load += new System.EventHandler(this.frmMerge_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileDefinition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelFilesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imlIcons;
        private System.Windows.Forms.TextBox txtProjectPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFileDefinition;
        private System.Windows.Forms.TextBox txtMasterFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMasterFile;
        private excelFilesDataSet excelFilesDataSet;
        private System.Windows.Forms.BindingSource configDataBindingSource;
        private excelFilesDataSetTableAdapters.configDataTableAdapter configDataTableAdapter;
        private System.Windows.Forms.ProgressBar pgbMergeFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn worksheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn initrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn endrow;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnExit;
    }
}

