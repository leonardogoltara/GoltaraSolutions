using Microsoft.AspNet.Identity;
using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace GoltaraSolutions.Common.Identity.Configuration
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            string hostSMTP = ConfigurationManager.AppSettings["EmailHostSMTP"];
            string username = ConfigurationManager.AppSettings["EmailUserName"];
            string password = ConfigurationManager.AppSettings["EmailSenha"];
            int port = 587;
            int.TryParse(ConfigurationManager.AppSettings["EmailPorta"], out port);
            bool usaSSL = false;
            bool.TryParse(ConfigurationManager.AppSettings["EmailSSL"], out usaSSL);
            SmtpClient smtpClient;

            smtpClient = new SmtpClient(hostSMTP, port);
            smtpClient.Credentials = new NetworkCredential(username, password);
            smtpClient.EnableSsl = usaSSL;


            try
            {
                MailMessage msg = new MailMessage(username, message.Destination, message.Subject, message.Body);
                msg.IsBodyHtml = true;
                smtpClient.Send(msg);
            }
            catch (Exception)
            {
                return Task.FromResult(0);
                //throw ex;
            }

            return Task.FromResult(0);
        }
    }
}
