# Singleton Pattern

## Problem

The uncontrolled creation of instances of expensive or shared resources
such as database connections, loggers, or configuration managers
creates two main problems:

- **Resource waste**: every `new` creates a costly object from scratch
- **Inconsistent state**: different instances may have different configurations, causing unpredictable behavior

## Solution

Singleton ensures that a class has only one instance during the entire lifetime of the application, centralizing access through a single point.

The mechanism has three parts:
- **Private constructor:** prevents external code from creating `new` instances
- **Static `_instance` field:** stores the single created instance
- **Static `GetInstance()`:** method creates the instance on the first call and returns the same one on every following call

To verify it, run the project and compare the `GetHashCode()` values of the two logger objects the value will be identical, confirming that it is the same instance.

## Alternative in .NET

`AddSingleton` in ASP.NET Core solves the same problem without those drawbacks:

```csharp
builder.Services.AddSingleton<ILogger, Logger>();
```

The container manages the single instance, the constructor remains public, and in tests you can inject a mock normally.

This is exactly the pattern used in the RabbitMqPublisher from the event-driven-dotnet project [event-driven-dotnet](https://github.com/ThomasDixini/event-driven-dotnet)
the RabbitMQ connection is expensive to create and should be reused, but it is registered through DI instead of using the classic Singleton.

## When NOT to use

When the object has no shared state or is not expensive to create.
Prefer dependency injection with `AddSingleton` over the classic Singleton in modern .NET projects.