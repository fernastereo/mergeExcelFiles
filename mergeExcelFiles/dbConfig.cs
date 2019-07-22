using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace mergeExcelFiles
{
    public class dbConfig
    {
        string textFile = AppDomain.CurrentDomain.BaseDirectory + "mail.txt";

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

        public void getMailconfigTxt() {

            string[] lines = File.ReadAllLines(textFile);
            if (lines.Length > 0)
            {
                Host = lines[0].ToString();
                Port = int.Parse(lines[1]);
                User = lines[2];
                Password = lines[3];
                enableSSL = int.Parse(lines[4]) == 1 ? true : false;
                Sender = lines[5];
            }
        }

        public bool saveMailSettingsTxt() {
           try
            {
                File.WriteAllText(textFile, String.Empty);
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(textFile))
                {
                    sw.WriteLine(Host);
                    sw.WriteLine(Port);
                    sw.WriteLine(User);
                    sw.WriteLine(Password);
                    sw.WriteLine(Sender);
                    sw.WriteLine(enableSSL == true ? 1 : 0);
                }
                return true;
            } catch (System.Exception e)
            {
                errMsg = e.Message;
                return false;
            }
        }

        public bool saveMailSettings()
        {
            try
            {
                using (OleDbConnection strConnection = new OleDbConnection(getConnectionString()))
                {
                    OleDbCommand cmdMailSettings = new OleDbCommand("update mailconfig set host=@host, port=@port, [user]=@user, [password]=@password, sender=@sender, enablessl=@enablessl where id=1", strConnection);
                    strConnection.Open();
                    cmdMailSettings.Parameters.AddWithValue("host", Host);
                    cmdMailSettings.Parameters.AddWithValue("port", Port);
                    cmdMailSettings.Parameters.AddWithValue("user", User);
                    cmdMailSettings.Parameters.AddWithValue("password", Password);
                    cmdMailSettings.Parameters.AddWithValue("sender", Sender);
                    cmdMailSettings.Parameters.AddWithValue("enablessl", enableSSL == true ? 1 : 0);
                    cmdMailSettings.ExecuteNonQuery();
                    return true;
                }
            }
            catch (System.Exception e)
            {
                errMsg = e.Message;
                return false;
            }
        }

        public static string getConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["mergeExcelFiles.Properties.Settings.excelFilesConnectionString"].ConnectionString.ToString();
        }
    }
}
