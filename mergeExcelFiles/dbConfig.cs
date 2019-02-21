using System.Data;
using System.Data.OleDb;

namespace mergeExcelFiles
{
    public class dbConfig
    {
        public string errMsg { get; private set; }

        public string Host { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public bool enableSSL { get; set; }
        public string Sender { get; set; }

        public void getMailconfig()
        {
            using (OleDbConnection strConnection = new OleDbConnection(getConnectionString()))
            {
                OleDbCommand cmdMailConfig = new OleDbCommand("select host, port, user, password, sender, enablessl from mailconfig where status=1", strConnection);
                strConnection.Open();
                OleDbDataReader dtrMailConfig = cmdMailConfig.ExecuteReader();
                if (dtrMailConfig.Read())
                {
                    Host = dtrMailConfig["host"].ToString();
                    Port = (int)dtrMailConfig["port"];
                    User = dtrMailConfig["user"].ToString();
                    Password = dtrMailConfig["password"].ToString();
                    Sender = dtrMailConfig["sender"].ToString();
                    enableSSL = (int)dtrMailConfig["enablessl"] == 1 ? true : false;
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
                    cmdMailSettings.Parameters.AddWithValue("host", Host);
                    cmdMailSettings.Parameters.AddWithValue("port", Port);
                    cmdMailSettings.Parameters.AddWithValue("user", User);
                    cmdMailSettings.Parameters.AddWithValue("password", Password);
                    cmdMailSettings.Parameters.AddWithValue("sender", Sender);
                    cmdMailSettings.Parameters.AddWithValue("enablessl", enableSSL);
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
