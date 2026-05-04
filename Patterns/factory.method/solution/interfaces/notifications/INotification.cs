using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solution.interfaces.notifications
{
    public interface INotification
    {
        void Send(string message);
    }
}