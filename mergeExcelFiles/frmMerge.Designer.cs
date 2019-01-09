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
            this.txtProjectPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.imlIcons = new System.Windows.Forms.ImageList(this.components);
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.excelFilesDataSet = new mergeExcelFiles.excelFilesDataSet();
            this.fileDefinitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileDefinitionTableAdapter = new mergeExcelFiles.excelFilesDataSetTableAdapters.fileDefinitionTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tittleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initrowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endrowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelFilesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDefinitionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProjectPrefix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnOpenPath);
            this.groupBox1.Controls.Add(this.txtProjectPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carpeta Proyecto";
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
            this.btnOpenPath.ImageKey = "icons8-save-50.png";
            this.btnOpenPath.ImageList = this.imlIcons;
            this.btnOpenPath.Location = new System.Drawing.Point(618, 22);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(27, 25);
            this.btnOpenPath.TabIndex = 2;
            this.btnOpenPath.UseVisualStyleBackColor = true;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // imlIcons
            // 
            this.imlIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcons.ImageStream")));
            this.imlIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlIcons.Images.SetKeyName(0, "icons8-save-50.png");
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Location = new System.Drawing.Point(99, 25);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(510, 20);
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
            this.initrowDataGridViewTextBoxColumn,
            this.endrowDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fileDefinitionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // excelFilesDataSet
            // 
            this.excelFilesDataSet.DataSetName = "excelFilesDataSet";
            this.excelFilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fileDefinitionBindingSource
            // 
            this.fileDefinitionBindingSource.DataMember = "fileDefinition";
            this.fileDefinitionBindingSource.DataSource = this.excelFilesDataSet;
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
            // 
            // tittleDataGridViewTextBoxColumn
            // 
            this.tittleDataGridViewTextBoxColumn.DataPropertyName = "tittle";
            this.tittleDataGridViewTextBoxColumn.HeaderText = "tittle";
            this.tittleDataGridViewTextBoxColumn.Name = "tittleDataGridViewTextBoxColumn";
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "filename";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            // 
            // initrowDataGridViewTextBoxColumn
            // 
            this.initrowDataGridViewTextBoxColumn.DataPropertyName = "initrow";
            this.initrowDataGridViewTextBoxColumn.HeaderText = "initrow";
            this.initrowDataGridViewTextBoxColumn.Name = "initrowDataGridViewTextBoxColumn";
            // 
            // endrowDataGridViewTextBoxColumn
            // 
            this.endrowDataGridViewTextBoxColumn.DataPropertyName = "endrow";
            this.endrowDataGridViewTextBoxColumn.HeaderText = "endrow";
            this.endrowDataGridViewTextBoxColumn.Name = "endrowDataGridViewTextBoxColumn";
            // 
            // frmMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.excelFilesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDefinitionBindingSource)).EndInit();
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
        private excelFilesDataSet excelFilesDataSet;
        private System.Windows.Forms.BindingSource fileDefinitionBindingSource;
        private excelFilesDataSetTableAdapters.fileDefinitionTableAdapter fileDefinitionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tittleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initrowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endrowDataGridViewTextBoxColumn;
    }
}

