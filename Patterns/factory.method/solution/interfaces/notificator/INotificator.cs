using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.interfaces.notifications;

namespace solution.interfaces.notificator
{
    public interface INotificator
    {
        INotification CreateNotification();
        void SendMessage(string message);
    }
}