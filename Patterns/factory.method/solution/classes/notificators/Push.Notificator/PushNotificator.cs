using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.classes.notifications.Push.Notifications;
using solution.interfaces.notifications;
using solution.interfaces.notificator;

namespace solution.classes.notificators.Push.Notificator
{
    public class PushNotificator : INotificator
    {
        public INotification CreateNotification()
        {
            return new PushNotification();
        }

        public void SendMessage(string message)
        {
            INotification notification = CreateNotification();
            notification.Send(message);
        }
    }
}