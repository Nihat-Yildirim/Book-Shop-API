using BookShopAPI.Application.Mailing;
using BookShopAPI.Domain.Mailing;
using BookShopAPI.Infrastructure.Helpers;
using MailKit.Net.Smtp;
using MimeKit;

namespace BookShopAPI.Infrastructure.Mailing.MailKit
{
    public class MailkitMailService : IMailService
    {
        private readonly MailSettings _settings;

        public MailkitMailService()
        {
            _settings = MailSettingsHelper.GetMailSettings();
        }

        public async Task SendAsync(Mail mail)
        {
            MimeMessage message = new();

            message.From.Add(new MailboxAddress(_settings.SenderFullName,_settings.SenderEmail));
            message.To.Add(new MailboxAddress(mail.ToFullName , mail.ToEmail));
            message.Subject = mail.Subject;

            BodyBuilder builder = new(){
                TextBody = mail.TextBody,
                HtmlBody = mail.HtmlBody
            };

            if(mail.Attachments != null) 
                foreach(MimeEntity? attachment in mail.Attachments)
                    builder.Attachments.Add(attachment);

            message.Body = builder.ToMessageBody();

            using SmtpClient smtpClient = new();
            smtpClient.CheckCertificateRevocation = false;
            await smtpClient.ConnectAsync(_settings.Host,_settings.Port,_settings.SSL);
            await smtpClient.AuthenticateAsync(_settings.SenderEmail, _settings.Password);
            await smtpClient.SendAsync(message);
            await smtpClient.DisconnectAsync(true);
        }
    }
}