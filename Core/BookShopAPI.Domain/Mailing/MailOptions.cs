namespace BookShopAPI.Domain.Mailing
{
    public class MailOptions
    {
        public string? SenderEmail { get; set; }
        public string? SenderFullName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Host { get; set; }
        public int Port { get; set; }
        public bool SSL { get; set; }
    }
}