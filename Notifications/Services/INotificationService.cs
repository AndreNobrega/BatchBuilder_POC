using Notifications.Model.Interfaces;

namespace Notifications.Services
{
    public interface INotificationService
    {
        INotification CreateNotification(string title, string message);
        IProgressNotification CreateProgressNotification(string title, string message);
        void DeleteNotification(INotification notification);
        void UpdateNotification(INotification notification);
    }
}