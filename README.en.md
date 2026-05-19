# 📌 Repository Purpose

This repository aims to provide **practical study of Design Patterns in C#**, focusing on **real-world software design problems**, not just theoretical examples.

Each pattern is presented following the same approach:

- A problematic scenario with intentionally coupled or hard-to-maintain code
- The application of the Design Pattern as a solution
- A clear comparison between before and after, highlighting benefits and trade-offs
- Observations about when to use and when to avoid each pattern

The project's focus is to demonstrate architectural reasoning, decision-making, and understanding of each pattern's impact on code, aligned with modern practices such as **low coupling, testability, and maintainability.**

## 📚 Implemented Patterns

### Creational Patterns

#### 1. **Singleton**
- **Purpose**: Ensure a class has only one instance
- **Problem**: Multiple instances cause state inconsistency
- **Solution**: Control instance creation within the class itself
- **When to use**: Configuration managers, database connections, loggers
- **Location**: `Patterns/singleton/`

#### 2. **Factory Method**
- **Purpose**: Create objects without exposing their concrete classes
- **Problem**: Client code becomes coupled to specific classes
- **Solution**: Delegate creation to a factory
- **When to use**: Systems with multiple implementations of an interface
- **Location**: `Patterns/factory.method/`

#### 3. **Builder**
- **Purpose**: Construct complex objects step by step
- **Problem**: Constructors with many parameters become unreadable
- **Solution**: Use a builder to assemble the object gradually
- **When to use**: Objects with many optional configurations
- **Location**: `Patterns/builder/`

### Structural Patterns

#### 4. **Adapter**
- **Purpose**: Adapt incompatible interfaces
- **Problem**: Client code needs to know multiple different APIs
- **Solution**: Create adapters that translate between interfaces
- **When to use**: Integration with external libraries or legacy code
- **Location**: `Patterns/adapter/`

#### 5. **Decorator**
- **Purpose**: Add responsibilities to an object dynamically
- **Problem**: Subclasses grow exponentially for each behavior combination
- **Solution**: Wrap objects in decorators that extend functionality
- **When to use**: Add cross-cutting concerns (caching, logging, validation)
- **Location**: `Patterns/decorator/`

#### 6. **Facade**
- **Purpose**: Provide a simplified interface for a complex subsystem
- **Problem**: Client needs to know many classes and their interactions
- **Solution**: Create a facade that encapsulates the complexity
- **When to use**: Simplify usage of libraries or complex subsystems
- **Location**: `Patterns/facade/`

### Behavioral Patterns

#### 7. **Strategy**
- **Purpose**: Encapsulate interchangeable algorithms
- **Problem**: Multiple if-else statements coupled to types
- **Solution**: Create strategies that implement a common interface
- **When to use**: Multiple ways of doing something and choosing at runtime
- **Location**: `Patterns/strategy/`

## 🚀 How to Use This Repository

Each pattern is organized in two folders:

- **`problem/`**: Code with the problematic approach (anti-pattern)
- **`solution/`**: Code applying the Design Pattern

### Run an example:

```bash
# Navigate to the desired pattern
cd Patterns/[pattern-name]/[problem or solution]

# Run with .NET
dotnet run [args-if-needed]
```

### Analyze the differences:

1. Read the `README.md` (or `README.en.md` for Portuguese) file of the pattern
2. Compare the code in `problem/Program.cs` with `solution/`
3. Observe how the solution solves the listed problems

## 📖 Key Concepts

- **Low Coupling**: Code independent of specific implementations
- **Open/Closed Principle**: Open for extension, closed for modification
- **Single Responsibility Principle**: Each class has one reason to change
- **Dependency Injection**: Classes receive their dependencies
- **Polymorphism**: Different behavior through common interfaces

## 🎯 Learning Goals

This project aims to provide:

- Practical understanding of each Design Pattern
- Recognition of when each pattern applies
- Ability to implement patterns in C#
- Understanding of trade-offs and limitations
- Solid foundation for architectural decision-making

The project is geared toward continuous learning and serves as reference material for interviews, technical reviews, and software architecture discussions.
