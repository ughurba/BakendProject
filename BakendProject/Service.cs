using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Net;
using System.Net.Mail;

namespace BakendProject
{
    public class Service
    {
        private readonly ILogger<Service> logger;

        public Service(ILogger<Service> logger)
        {
            this.logger = logger;
        }


      
        public void SendEmailDefault(string email)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("ughurba@code.edu.az", "myCompany");
                    mail.To.Add(email);
                    mail.Subject = "Product";
                    mail.Body = "<h1>Product add olundu</h1>";
                    mail.IsBodyHtml = true;
                    logger.LogInformation("nice");

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("mail", "password");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }

            }
            catch(Exception e)
            {
                logger.LogError(e.GetBaseException().Message);
            }

        }
      
    }
}
