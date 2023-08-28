using MimeKit;

namespace BookShopAPI.Domain.Mailing
{
    public class Mail
    {
        public string? Subject { get; set; }
        public string? ToEmail { get; set; }
        public string? ToFullName { get; set; }
        public string? HtmlBody { get; set; }
        public string? TextBody { get; set; }
        public List<MimeEntity>? Attachments { get; set; }
    }
}