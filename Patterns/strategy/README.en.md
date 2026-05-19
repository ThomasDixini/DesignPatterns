# Explanation

This example implements the Strategy Pattern to allow applying different discount strategies
without the client code needing to know the details of each implementation.

In this case, we have a generic discount service that depends on a common interface (`ICustomerDiscountStrategy`) and
receives concrete strategies for no discount, loyalty discount, coupon discount, etc.

### Problem

Each discount strategy has its own calculation logic. Without the Strategy Pattern, the code becomes full of
`if-else` statements and type checks, causing:

- coupling between discount logic and specific strategy types
- difficulty adding new strategies without modifying existing code
- inability to switch strategies at runtime
- violation of the Open/Closed Principle (open for extension, closed for modification)

### Solution

The Strategy Pattern creates a layer of abstraction through an interface that defines the common contract for all
strategies. Thus, new strategies can be added without modifying existing code.

In the example:

- `ICustomerDiscountStrategy` defines the common operation `CalculateDiscount(decimal totalAmount)`
- `NoDiscountStrategy`, `LoyaltyDiscountStrategy`, and `CouponDiscountStrategy` implement that interface
- `DiscountContext` accepts any `ICustomerDiscountStrategy` and delegates the calculation
- The strategy can be switched at runtime via `SetDiscountStrategy()`

That way, the client always uses the same interface and the strategies encapsulate the specific calculation logic.

### When to use

Use Strategy when:

- you have multiple ways of doing something and need to choose which one to use at runtime
- you want to avoid long `if-else` statements coupled to types
- you wish to add new strategies without modifying existing code
- you need to encapsulate variable behaviors

### When NOT to use

Don't use when you have only one way of doing something or when the logic is very simple. In that case,
the Strategy would add unnecessary complexity.

### Benefits

- **Extensibility**: New strategies can be easily added
- **Flexibility**: Strategies can be switched at runtime
- **Maintainability**: Each strategy is isolated in its own class
- **Testability**: Each strategy can be tested independently
