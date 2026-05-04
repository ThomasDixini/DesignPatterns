using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.interfaces.notifications;

namespace solution.classes.notifications.Push.Notifications
{
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            // Here, would go the logic to send push notification.
            Console.WriteLine($"Sending push notification with message: {message}");
        }
    }
}