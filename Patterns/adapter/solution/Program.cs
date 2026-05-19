// See https://aka.ms/new-console-template for more information

using solution.classes;

var expoAdapter = new NotificationService(new ExpoPushAdapter());
expoAdapter.SendNotification("Hello from Expo!");

Console.WriteLine("--------------------------");

var firebaseAdapter = new NotificationService(new FirebasePushAdapter());
firebaseAdapter.SendNotification("Hello from Firebase!");