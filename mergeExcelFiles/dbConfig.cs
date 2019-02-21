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
        private string _sender;

        public string errMsg { get; private set; }

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

        public string Sender
        {
            get { return _sender; }
        }

        public dbConfig()
        {
            getMailconfig();
        }

        private void getMailconfig()
        {
            using (OleDbConnection strConnection = new OleDbConnection(getConnectionString()))
            {
                OleDbCommand cmdMailConfig = new OleDbCommand("select host, port, user, password, sender, enablessl from mailconfig where status=1", strConnection);
                strConnection.Open();
                OleDbDataReader dtrMailConfig = cmdMailConfig.ExecuteReader();
                if (dtrMailConfig.Read())
                {
                    _host = dtrMailConfig["host"].ToString();
                    _port = (int)dtrMailConfig["port"];
                    _user = dtrMailConfig["user"].ToString();
                    _password = dtrMailConfig["password"].ToString();
                    _sender = dtrMailConfig["sender"].ToString();
                    _enableSSL = (int)dtrMailConfig["enablessl"] == 1 ? true : false;
                }
                dtrMailConfig.Close();
            }
        }

        public bool saveMailSettings()
        {
            try
            {
                using (OleDbConnection strConnection = new OleDbConnection(getConnectionString()))
                {
                    OleDbCommand cmdMailSettings = new OleDbCommand("update mailconfig set host=@host, port=@port, user=@user, password=@password, sender=@sender, enablessl=@enablessl where id=1", strConnection);
                    cmdMailSettings.Parameters.AddWithValue("host", _host);
                    cmdMailSettings.Parameters.AddWithValue("port", _port);
                    cmdMailSettings.Parameters.AddWithValue("user", _user);
                    cmdMailSettings.Parameters.AddWithValue("password", _password);
                    cmdMailSettings.Parameters.AddWithValue("sender", _sender);
                    cmdMailSettings.Parameters.AddWithValue("enablessl", _enableSSL);
                    cmdMailSettings.ExecuteNonQuery();
                    return true;
                }

            }
            catch (System.Exception e)
            {
                throw new System.Exception("Se ha producido un error al guardar. ", e);
            }
        }
        public static string getConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["mergeExcelFiles.Properties.Settings.excelFilesConnectionString"].ConnectionString.ToString();
        }
    }
}
