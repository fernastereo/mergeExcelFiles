using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace mergeExcelFiles
{
    public class emailAdmin
    {
        private SmtpClient client;
        private MailMessage mail;
        private string _host;
        private int _port;
        private string _user;
        private string _pass;
        private bool _essl;

        public emailAdmin(string host, int port, string user, string pass, bool essl)
        {
            _host = host;
            _port = port;
            _user = user;
            _pass = pass;
            _essl = essl;

            client = new SmtpClient(_host, _port) {
                EnableSsl = _essl,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_user, _pass)
            };
        }
    }
}
