using Notifications.Model.Enums;

namespace Notifications.Model.Interfaces
{
    internal interface IProgressNotification : INotification
    {
        public int TotalItems { get; set; }
        public int ItemsSucceeded { get; set; }
        public int ItemsFailed { get; set; }
        public ProgressState ProgressState { get; set; }
    }
}
