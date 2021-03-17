using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace Curriculum_Vitae.Services
{
    public class EmailService
    {
        private static EmailService emailService = null;
        private string mailTo;
        private string userName;
        private string password;

        private EmailService()
        {
            userName = ConfigurationManager.AppSettings["userName"];
            mailTo = ConfigurationManager.AppSettings["mailTo"];
            password = ConfigurationManager.AppSettings["password"];
        }

        public static EmailService Instance
        {
            get
            {
                if (emailService == null)
                    emailService = new EmailService();
                return emailService;
            }
        }

        public void SendEmail(string emailOrigen, string asunto, string mensaje)
        {

            MailAddress mailFrom = new MailAddress(userName, emailOrigen);
            MailMessage mail = new MailMessage();
            mail.To.Add(mailTo);
            mail.From = mailFrom;
            mail.Subject = asunto;
            mail.Body = mensaje;
            mail.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient()
            {
                Host = "smtp.outlook.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(userName, password),
                Timeout = 20000
            };

            smtp.Send(mail);
        }
    }
}