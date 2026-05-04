// See https://aka.ms/new-console-template for more information
if(args.Count() == 0 || string.IsNullOrEmpty(args[0])) throw new ArgumentException("No argument provided");


var notificationService = new NotificationService();
notificationService.Send("Hello, this is a notification!", args[0]);

public class NotificationService
{
    public void Send(string message, string type)
    {
        if(type == "push")
        {
            // Logic to send push notification, In that case would be using a third party library like Expo Push Notifications or Firebase Cloud Messaging as same as my Application mobile project
            Console.WriteLine($"Sending push notification with message: {message}");
        }
        else if(type == "email")
        {
            Console.WriteLine($"Sending email with message: {message}");
        }
        else if(type == "sms")
        {
            Console.WriteLine($"Sending SMS with message: {message}");
        }
        else
        {
            throw new ArgumentException("Invalid notification type");
        }
    }
}