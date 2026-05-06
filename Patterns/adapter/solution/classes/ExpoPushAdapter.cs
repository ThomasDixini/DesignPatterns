using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.interfaces;

namespace solution.classes
{
    public class ExpoPushAdapter : INotificationService
    {
        public ExpoPushAdapter() 
        {
            // DI can be used here to inject the third-party service
            // Here we would initialize the Expo Push service, e.g., setting up API keys, etc.
             Console.WriteLine("Initializing Expo Push service... (Simulating resource)");
        }

        public void SendNotification(string message)
        {
            Console.WriteLine("Adapting message for Expo Push...");
            Console.WriteLine($"Sending notification via Expo Push: {message}");
        }
    }
}