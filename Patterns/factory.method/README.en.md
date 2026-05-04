# Explanation

I implemented this pattern with the goal of creating different types of notification sending implementations, using a real example from one of my projects as the basis.

### Problem

Our system started by sending only push notifications.  
But what if, one day, we need to support email and SMS as well?

Without this pattern, the creation logic would look like this:

if (type == "push") return new PushNotification();
else if (type == "email") return new EmailNotification();
else if (type == "sms") return new SmsNotification();

This breaks two principles:

- **SRP**: `NotificationService` takes on both the responsibility of creating and sending notifications
- **OCP**: every time a new type is added, we need to modify existing code

Our notification logic would become more complex and completely coupled to our `NotificationService` class, handling only one type of notification and growing every time new ones are added. Because of that, any change in this logic would impact every part of the system that uses it.

### Solution

The Factory Method defines an interface for creating the object (**INotificator**) and delegates the decision of which object to create to concrete subclasses/implementations (classes that implement **INotification**).

Whoever calls **INotificator** does not know which implementation will be returned, only that it receives something that implements **INotification**.

To add EMAIL: we create **EmailNotificator** without changing anything existing.

### When NOT to use

When you have only one type of object and variation is unlikely.  
This pattern adds complexity, so it is only worth it when extensibility is a real requirement.