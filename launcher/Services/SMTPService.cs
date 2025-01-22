using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace launcher.Services
{
    internal class SMTPService
    {
        private string _login;
        private string _password;

        private SmtpClient _smtpClient;
        public SMTPService(string login = null, string password = null)
        {
            _login = login;
            _password = password;
        }
        /*public void Auth()
        {
            using (var client = new SmtpClient())
            {
                client.Connect(
                    "smtp.titan.email", 
                    465, 
                    MailKit.Security.SecureSocketOptions.SslOnConnect
                );

                client.Authenticate(_login, _password);

                _smtpClient = client;
            };
        }*/
        public bool SendEmail(string receiver = null, string subject = null, string messageText = null)
        {
            try
            {
                using (var client = new SmtpClient())
                {
                    client.Connect(
                        "smtp.titan.email",
                        465,
                        MailKit.Security.SecureSocketOptions.SslOnConnect
                    );
                    client.Authenticate(_login, _password);

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Miamilux", _login));
                    message.To.Add(new MailboxAddress("", receiver));
                    message.Subject = subject;
                    message.Body = new TextPart("plain")
                    {
                        Text = messageText
                    };

                    client.Send(message);
                    client.Disconnect(true);
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
