using AutoMapper;
using Sofra.DAL.Abstract;
using Sofra.Service.Abstract;
using Sofra.Service.Validation;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Sofra.Service.Concrete
{
    public class MailService(string smtpHost, int smtpPort, string smtpUsername, string smtpPassword, string sendBy) : IMailService
    {
        private readonly string _smtpHost = smtpHost;
        private readonly int _smtpPort = smtpPort;
        private readonly string _smtpUsername = smtpUsername;
        private readonly string _smtpPassword = smtpPassword;
        private readonly string _sendBy = sendBy;
        public async Task SendMail(string sendTo, DateTime date)
        {
            // TODO: Implement RabbitMQ
            using (var smtpClient = new SmtpClient(_smtpHost, _smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
                smtpClient.EnableSsl = true;

                var mailMesaji = new MailMessage(_sendBy, sendTo)
                {
                    Subject = "Rezervasyon Onayı",
                    Body = $"Merhaba,\n\n{date:G}\n\n tarihli rezervasyonunuz başarıyla tamamlanmıştır. İlginiz için teşekkür ederiz.",
                    IsBodyHtml = true
                };

                await smtpClient.SendMailAsync(mailMesaji);
            }
        }
    }
}
