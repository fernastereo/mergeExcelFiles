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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileDefinitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileDefinitionDataSet = new mergeExcelFiles.fileDefinitionDataSet();
            this.fileDefinitionTableAdapter = new mergeExcelFiles.fileDefinitionDataSetTableAdapters.fileDefinitionTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tittleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worksheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initrowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endrowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDefinitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDefinitionDataSet)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tittleDataGridViewTextBoxColumn,
            this.filenameDataGridViewTextBoxColumn,
            this.worksheet,
            this.initrowDataGridViewTextBoxColumn,
            this.endrowDataGridViewTextBoxColumn,
            this.Estado});
            this.dataGridView1.DataSource = this.fileDefinitionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 312);
            this.dataGridView1.TabIndex = 1;
            // 
            // fileDefinitionBindingSource
            // 
            this.fileDefinitionBindingSource.DataMember = "fileDefinition";
            this.fileDefinitionBindingSource.DataSource = this.fileDefinitionDataSet;
            // 
            // fileDefinitionDataSet
            // 
            this.fileDefinitionDataSet.DataSetName = "fileDefinitionDataSet";
            this.fileDefinitionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fileDefinitionTableAdapter
            // 
            this.fileDefinitionTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // tittleDataGridViewTextBoxColumn
            // 
            this.tittleDataGridViewTextBoxColumn.DataPropertyName = "tittle";
            this.tittleDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.tittleDataGridViewTextBoxColumn.Name = "tittleDataGridViewTextBoxColumn";
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "Archivo";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            // 
            // worksheet
            // 
            this.worksheet.DataPropertyName = "worksheet";
            this.worksheet.HeaderText = "Hoja";
            this.worksheet.Name = "worksheet";
            // 
            // initrowDataGridViewTextBoxColumn
            // 
            this.initrowDataGridViewTextBoxColumn.DataPropertyName = "initrow";
            this.initrowDataGridViewTextBoxColumn.HeaderText = "Inicio";
            this.initrowDataGridViewTextBoxColumn.Name = "initrowDataGridViewTextBoxColumn";
            // 
            // endrowDataGridViewTextBoxColumn
            // 
            this.endrowDataGridViewTextBoxColumn.DataPropertyName = "endrow";
            this.endrowDataGridViewTextBoxColumn.HeaderText = "Final";
            this.endrowDataGridViewTextBoxColumn.Name = "endrowDataGridViewTextBoxColumn";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // frmMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDefinitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDefinitionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imlIcons;
        private System.Windows.Forms.TextBox txtProjectPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMasterFile;
        private System.Windows.Forms.Label label3;
        private fileDefinitionDataSet fileDefinitionDataSet;
        private System.Windows.Forms.BindingSource fileDefinitionBindingSource;
        private fileDefinitionDataSetTableAdapters.fileDefinitionTableAdapter fileDefinitionTableAdapter;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tittleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn worksheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn initrowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endrowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}

