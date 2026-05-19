using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.interfaces;

namespace solution.classes
{
    public class FirebasePushAdapter : INotificationService
    {
        public FirebasePushAdapter() 
        {
            // DI can be used here to inject the third-party service
            // Here we would initialize the Firebase Cloud Messaging, e.g., setting up API keys, etc.
             Console.WriteLine("Initializing Firebase Cloud Messaging... (Simulating resource)");
        }

        public void SendNotification(string message)
        {
            Console.WriteLine("Adapting message for Firebase Cloud Messaging...");
            Console.WriteLine($"Sending notification via Firebase Cloud Messaging: {message}");
        }
    }
}