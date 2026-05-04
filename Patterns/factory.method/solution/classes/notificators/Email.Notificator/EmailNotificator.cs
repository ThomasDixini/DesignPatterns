using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.classes.notifications.Email.Notification;
using solution.interfaces.notifications;
using solution.interfaces.notificator;

namespace solution.classes.notificators.Email.Notificator
{
    public class EmailNotificator : INotificator
    {
        public INotification CreateNotification()
        {
            return new EmailNotification();
        }

        public void SendMessage(string message)
        {
            INotification notification = CreateNotification();
            notification.Send(message);
        }
    }
}