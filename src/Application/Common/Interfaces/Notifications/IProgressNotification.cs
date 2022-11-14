using Domain.Enums;

namespace Application.Common.Interfaces.Notifications
{
    internal interface IProgressNotification : INotification
    {
        public int TotalItems { get; set; }
        public int ItemsSucceeded { get; set; }
        public int ItemsFailed { get; set; }
        public ProgressState ProgressState { get; set; }
    }
}
