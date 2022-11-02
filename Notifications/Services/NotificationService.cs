using Notifications.Model.Interfaces;

namespace Notifications.Services
{
    public class NotificationService : INotificationService
    {
        public void UpdateNotification(INotification notification)
        {
            throw new NotImplementedException(); //todo: handle notification updates
        }

        public void DeleteNotification(INotification notification)
        {
            throw new NotImplementedException(); //todo: handle notification deletion
        }

        public INotification CreateNotification(string title, string message)
        {
            throw new NotImplementedException(); //todo: handle notification creation
        }

        public IProgressNotification CreateProgressNotification(string title, string message)
        {
            throw new NotImplementedException(); //todo: handle progress notification creation
        }
    }
}