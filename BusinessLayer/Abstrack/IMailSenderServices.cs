using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BusinessLayer.Abstrack
{
    public class MailSenderServices : ISenderServices
    {
        private readonly ILogger<MailSenderServices> _logger;

        public MailSenderServices(ILogger<MailSenderServices> logger)
        {
            _logger = logger;
        }


        public async Task SenderEmail(string nameandsurname, string email, string subject, string message)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("mt-prime-win.guzelhosting.com"))
                {
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential("info@pekova.com.tr", "9Mcbh9*76");
                    smtpClient.EnableSsl = true;
                    string recipientEmail = $"{email}";
                    string emailTitle = $"{subject}";
                    string emailBody = $"Ad Soyad: {nameandsurname}\nE-posta: {email}\nMesaj: {message}";

                    MailMessage mail = new MailMessage(recipientEmail, "info@pekova.com.tr",  emailTitle, emailBody);

                    await smtpClient.SendMailAsync(mail);
                    _logger.LogInformation($"Başarılı Şekilde Gönderildi. Gönderen Mail {email}. Gönderen Kişi {nameandsurname}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"E-posta gönderirken bir hata oluştu: {ex.Message}");
                throw;
            }
        }
    }
}
