# Explanation

This example implements the Adapter Pattern to allow sending notifications through different providers
without the rest of the application needing to know the details of each implementation.

In this case, we have a generic notification service that depends on a common interface (`INotificationService`)
and receives concrete adapters for Expo Push and Firebase Cloud Messaging.

### Problem

Each notification service has its own API and message format.
Without the Adapter, the client code would need to know and handle each different implementation, causing:

- coupling between send logic and provider-specific code
- duplicated code to adapt messages
- difficulty replacing or adding new providers

### Solution

The Adapter creates a translation layer between the interface used by the application and the provider-specific implementation.

In the example:

- `INotificationService` defines the common operation `SendNotification(string message)`
- `ExpoPushAdapter` and `FirebasePushAdapter` implement that interface
- `NotificationService` accepts any `INotificationService` and delegates the call

That way, the client always uses the same interface and the adapters encapsulate the incompatibility of each provider.


### When to use

Use Adapter when:

- You need to integrate a external or legacy class with different interfaces used by your system.
- You want avoid that client code depends directly from specif APIs.
- You wish change implentation without change the service interface.

### When NOT to use

Do not use Adapter when all implementations already share the same interface or when there is no incompatibility to bridge.
In that case, the Adapter would add unnecessary complexity without providing real benefits.