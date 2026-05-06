using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.interfaces;

namespace solution.classes
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationService _notificationService;

        public NotificationService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void SendNotification(string message)
        {
            _notificationService.SendNotification(message);
        }
    }
}