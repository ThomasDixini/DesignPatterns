// See https://aka.ms/new-console-template for more information
using solution.classes.notificators.Email.Notificator;
using solution.classes.notificators.Push.Notificator;
using solution.interfaces.notificator;

if (args.Count() == 0 || string.IsNullOrEmpty(args[0])) throw new ArgumentException("No argument provided");

switch (args[0])
{
    case "push":
        INotificator pushNotificator = new PushNotificator();
        pushNotificator.SendMessage("Hello, World!");
        break;
    case "email":
        INotificator emailNotificator = new EmailNotificator();
        emailNotificator.SendMessage("Hello, World!");
        break;
    default:
        throw new ArgumentException("Invalid notification type");
};
