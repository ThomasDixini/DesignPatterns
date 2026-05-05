# Explanation

I implemented this pattern with the goal of simulating the creation of different versions of a sales report, as well as simulating the filtering of what would otherwise be an `IQueryable`.

### Problem

The number of **overloads** in the constructor grows with each new parameter added.  
In the example, there were only 3, but with 10 parameters the signature becomes hard to read and prone to errors. The user may pass values in the wrong order or not understand what a `null` in the middle of the arguments means.

An alternative would be to use subclasses, but that only trades one problem for another: a new subclass for each variation, making the system more complex with every new implementation.

In both cases, the code grows in complexity without becoming clearer.

### Solution

With the Builder, we remove the problem of **overloads** by separating the construction logic from the business rules of the class, following the Single Responsibility Principle.

In addition, the pattern allows us to create multiple variations of the same object and build only the necessary parts, without forcing the client to know the internal details of how the object is assembled.