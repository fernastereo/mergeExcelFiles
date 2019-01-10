using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace mergeExcelFiles
{
    class dbAccess
    {
        public const string BASE_PREFIX = "XXX";

        private string _prefix;
        private string _masterFile;

        public string masterFile {
            get {
                _masterFile = "";
                OleDbDataAdapter dtaMasterfile = new OleDbDataAdapter("select masterfile from configdata where status=1", new OleDbConnection(getConnectionString()));
                DataTable dttMasterFile = new DataTable();
                dtaMasterfile.Fill(dttMasterFile);
                if (dttMasterFile.Rows.Count > 0)
                {
                    string baseFile = dttMasterFile.Rows[0]["masterfile"].ToString();
                    _masterFile = baseFile.Replace(BASE_PREFIX, _prefix);
                }
                return _masterFile;
            }
        }


        public static string getConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["mergeExcelFiles.Properties.Settings.excelFilesConnectionString"].ConnectionString.ToString();
        }

        public dbAccess(string prefix)
        {
            _prefix = prefix;
        }

        public dbAccess()
        {
            _prefix = "";
        }
    }
}
