using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.interfaces.notifications;

namespace solution.classes.notifications.Email.Notification
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending email notification with message: " + message);
        }
    }
}