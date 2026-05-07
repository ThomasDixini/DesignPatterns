# Explanation

This example demonstrates the Decorator Pattern by applying additional behaviors to a schedule repository without modifying the concrete class.

The idea is to encapsulate concerns like caching and logging in decorator classes that implement the same interface (`ISchedulesRepository`) and forward calls to the wrapped object.

### Problem

Without the Decorator, adding new responsibilities to the repository would require changing `ScheduleRepository` directly or creating subclasses for every behavior combination.
That leads to:

- coupling between data access logic and cross-cutting concerns;
- duplicated code across similar classes;
- difficulty combining, replacing, or extending behaviors dynamically.

### Solution

The Decorator solves this by moving extra behavior into independent classes that wrap a base implementation.

In the example:

- `ISchedulesRepository` defines the common contract `GetScheduleById(int id)`;
- `ScheduleRepository` implements the standard access to the simulated database;
- `CachingScheduleRepository` decorates another `ISchedulesRepository` instance and adds caching;
- `LoggingScheduleDecorator` decorates another instance and adds logging.

This way, the client can compose a chain of decorators with extra responsibilities without modifying the base class, keeping the code more flexible and easier to extend.


### When not use

When you have only one fixed additional behavior and without variation perspective.
If the repository will have logging and never change, add direct behavior in class is more simple than
create a chain of decorators.

### Real Examples

The ASP.NET Core pipeline middleware is a pure decorator. Each `app.Use()`
wrap the next handler adding behavior (auth, CORS, logging) without modificate internal handlers.
