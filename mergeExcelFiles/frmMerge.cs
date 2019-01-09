using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mergeExcelFiles
{
    public partial class frmMerge : Form
    {
        const string BASE_PREFIX = "XXX";

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
            }
        }

        private void frmMerge_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'excelFilesDataSet.fileDefinition' Puede moverla o quitarla según sea necesario.
            this.fileDefinitionTableAdapter.Fill(this.excelFilesDataSet.fileDefinition);

        }
    }
}
