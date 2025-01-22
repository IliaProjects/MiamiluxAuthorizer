using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace launcher.Classes
{
    public class SMTPService_old
    {
        private string _login;
        private string _password;

        private SmtpClient _smtpClient;
        public SMTPService_old(string login = null, string password = null) {
            _login = login;
            _password = password;
        }

        public void Auth()
        {
            SmtpClient smtpClient = new SmtpClient()
            {

                /*Host = "smtp.titan.email",
                Port = 465,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_login, _password)*/
                
                Host = "mail.miamilux.us",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_login, _password)
                
                /*Host = "smtp.mail.ru",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_login, _password)*/
            };
            _smtpClient = smtpClient;
        }

        public bool SendEmail (string receiver = null, string subject = null, string messageText = null)
        {
            try
            {
                Auth();
                MailAddress fromAddress = new MailAddress(_login, "Miamilux");
                MailAddress toAddress = new MailAddress(receiver);
                using (MailMessage message = new MailMessage(fromAddress, toAddress))
                {
                    message.Subject = subject;
                    message.Body = messageText;
                    message.IsBodyHtml = false;
                    _smtpClient.Send(message);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
