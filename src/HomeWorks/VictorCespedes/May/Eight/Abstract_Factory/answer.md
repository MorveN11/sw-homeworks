## Abstract Factory

The Abstract Factory Pattern is a way of organizing how you create groups of things that are related to each other. It provides a set of rules or instructions that let you create different types of things without knowing exactly what those things are. This helps you keep everything organized and lets you switch between different types easily, following the same set of rules.

- Abstract Factory pattern is almost similar to Factory Pattern and is considered as another layer of abstraction over factory pattern.
- Abstract Factory patterns work around a super-factory which creates other factories.
- Abstract factory pattern implementation provides us with a framework that allows us to create objects that follow a general pattern.
- So at runtime, the abstract factory is coupled with any desired concrete factory which can create objects of the desired type.

## Components

1. Abstract Factory
Abstract Factory serves as a high-level blueprint that defines a set of rules for creating families of related objects without specifying their concrete classes. It declares a series of methods, each responsible for creating a particular type of object and ensures that concrete factories adhere to a common interface, providing a consistent way to produce related sets of objects.

2. Concrete Factories
Concrete Factories implement the rules specified by the abstract factory. It contain the logic for creating specific instances of objects within a family. Also multiple concrete factories can exist, each tailored to produce a distinct family of related objects.

3. Abstract Products
Abstract Products represents a family of related objects by defining a set of common methods or properties. It acts as an abstract or interface type that all concrete products within a family must adhere to and provides a unified way for concrete products to be used interchangeably.

4. Concrete Products
They are the actual instances of objects created by concrete factories. They implement the methods declared in the abstract products, ensuring consistency within a family and belong to a specific category or family of related objects.

5. Client
Client utilizes the abstract factory to create families of objects without specifying their concrete types and interacts with objects through abstract interfaces provided by abstract products. Client enjoys the flexibility of seamlessly switching between families of objects by changing the concrete factory instance.