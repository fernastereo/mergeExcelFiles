using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;


namespace mergeExcelFiles
{
    public class emailAdmin
    {
        private SmtpClient client;
        private MailMessage email;

        public emailAdmin()
        {
            client = new SmtpClient();
        }

        private static void inicializaConfiguracion()
        {
            
        }
    }
}
