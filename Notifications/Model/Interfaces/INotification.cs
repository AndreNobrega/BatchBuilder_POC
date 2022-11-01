namespace Notifications.Model.Interfaces
{
    public interface INotification
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Url { get; set; }
        public string UrlLabel { get; set; }

    }
}
