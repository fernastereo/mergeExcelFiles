using System.Data;
using System.Data.OleDb;

namespace mergeExcelFiles
{
    public class dbConfig
    {
        private string _host;
        private string _user;
        private string _password;
        private int _port;
        private bool _enableSSL;

        public string Host
        {
            get { return _host; }
        }

        public string User
        {
            get { return _user; }
        }

        public string Password
        {
            get { return _password; }
        }

        public int Port
        {
            get { return _port; }
        }

        public bool enableSSL
        {
            get { return _enableSSL; }
        }

        public dbConfig()
        {
            getMailconfig();
        }

        private void getMailconfig()
        {
            OleDbConnection strConnection = new OleDbConnection(getConnectionString());
            OleDbCommand cmdMailConfig = new OleDbCommand("select host, port, user, password, enablessl from mailconfig where status=1", strConnection);
            strConnection.Open();
            OleDbDataReader dtrMailConfig = cmdMailConfig.ExecuteReader();
            if (dtrMailConfig.Read())
            {
                _host = dtrMailConfig["host"].ToString();
                _port = (int)dtrMailConfig["port"];
                _user = dtrMailConfig["user"].ToString();
                _password = dtrMailConfig["password"].ToString();
                _enableSSL = (int)dtrMailConfig["enablessl"] == 1 ? true : false ;
            }
            dtrMailConfig.Close();
        }

        public static string getConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["mergeExcelFiles.Properties.Settings.excelFilesConnectionString"].ConnectionString.ToString();
        }
    }
}
