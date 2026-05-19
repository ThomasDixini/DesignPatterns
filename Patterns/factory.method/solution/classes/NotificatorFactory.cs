using System;
using solution.classes.notificators.Email.Notificator;
using solution.classes.notificators.Push.Notificator;
using solution.interfaces.notificator;

namespace solution.classes
{
    public class NotificatorFactory
    {
        public static INotificator CreateNotificator(string type)
        {
            return type.ToLower() switch
            {
                "push" => new PushNotificator(),
                "email" => new EmailNotificator(),
                _ => throw new ArgumentException($"Invalid notification type: {type}")
            };
        }
    }
}
