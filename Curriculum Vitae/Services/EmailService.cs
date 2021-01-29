using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace Curriculum_Vitae.Services
{
    public static class EmailService
    {
        public static void SendEmail(string emailOrigen, string asunto, string mensaje)
        {
            MailAddress mailFrom = new MailAddress(ConfigurationManager.AppSettings["username"], emailOrigen);
            MailMessage mail = new MailMessage();
            mail.To.Add(ConfigurationManager.AppSettings["personalEmail"]);
            mail.From = mailFrom;
            mail.Subject = asunto;
            mail.Body = mensaje;
            mail.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(ConfigurationManager.AppSettings["username"], ConfigurationManager.AppSettings["password"]),
                Timeout = 20000
            };

            smtp.Send(mail);
        }
    }
}