using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DoctorWho.Notification.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly IConfiguration _configuration;

        public EmailSenderService(IConfiguration configuration)
        {
            _configuration = configuration ??
                throw new ArgumentNullException(nameof(configuration));
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body, bool isBodyHTML)
        {
            var fromMail = _configuration["EmailSenderService:SenderEmail"];
            var fromPassword = _configuration["EmailSenderService:SenderEmailPassword"];
            var senderDisplayName = _configuration["EmailSenderService:SenderDisplayName"];

            var mailMessage = new MailMessage(fromMail, toEmail, subject, body)
            {
                From = new MailAddress(fromMail, senderDisplayName),
                IsBodyHtml = isBodyHTML
            };

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.SendAsync(mailMessage, null);
        }
    }
}
