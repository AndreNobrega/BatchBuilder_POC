using Notifications.Model.Interfaces;

namespace Notifications
{
    public interface INotificationService
    {
        void CreateNotification(INotification notification);
        void DeleteNotification(INotification notification);
        void UpdateNotification(INotification notification);
    }
}