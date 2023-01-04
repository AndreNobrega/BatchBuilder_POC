namespace Application.Common.Interfaces.Notifications
{
	internal interface INotificationService
	{
		INotification CreateNotification(string title, string message);
		IProgressNotification CreateProgressNotification(string title, string message);
		void DeleteNotification(INotification notification);
		void UpdateNotification(INotification notification);
	}
}
