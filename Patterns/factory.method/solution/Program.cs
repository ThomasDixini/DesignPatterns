// See https://aka.ms/new-console-template for more information
using solution.classes;
using solution.interfaces.notificator;

if (args.Count() == 0 || string.IsNullOrEmpty(args[0])) 
    throw new ArgumentException("No argument provided");

// Factory Method: Create the appropriate notificator without knowing the concrete type
INotificator notificator = NotificatorFactory.CreateNotificator(args[0]);
notificator.SendMessage("Hello, World!");
