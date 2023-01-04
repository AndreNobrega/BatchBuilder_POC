namespace Application.Common.Interfaces.Notifications
{
	internal interface INotification
	{
		public int NotificationId { get; set; }
		public string Title { get; set; }
		public string Message { get; set; }
		public string Url { get; set; }
		public string UrlLabel { get; set; }
	}
}
