# <div align="center">TEMPLATE & STRATEGY PATTERN DESIGN</h1>

**Name:** Victor Alejandro Cespedes Cartagena

## STRATEGY DESIGN PATTERN

The Strategy design pattern is a way to encapsulate repeated code with small differences in its operation, avoiding the repetitive use of if. This makes the code more efficient, avoiding code repetition and better readability.

Stratgy uses composition to solve the problem, the class that uses the strategy is an interface that represents the functionality to implement.

The Strategy design pattern is based on the “has a” relationship, which means that a class contains (or “has”) a reference to an interface that defines a specific behavior. In this pattern, a main class  “has” a strategy that can be dynamically exchanged as needed.


## TEMPLATE DESIGN PATTERN

Unlike strategy, template is based on the inheritance of abstract classes, using polymorphism to be able to define different behaviors. 

The subclasses created from this subclass may or may not implement the methods of the super class. The methods can be overridden as well as they can already have a default behavior. This is mostly used when you repeat a lot of code, have many if statements, or perform the same steps for certain functions and behaviors.

The Template design pattern is based on the “is a” relationship, which means that a derived class is a specialization of a base class. In this pattern, a base class defines the general structure of an algorithm, while derived classes provide concrete implementations of certain steps of that algorithm.

## Similarities
- Both allow encapsulation of algorithms and behaviors.
- They provide a way to handle different variants of an algorithm.
- Avoid repetition of code.

## Differences
#### Template
- Uses inheritance to specialize behavior.
- The structure of the algorithm is predefined in the base class and cannot be changed dynamically at runtime.

#### Strategy
- It uses composition, which allows us to dynamically change the behavior at runtime.
- Allows algorithms to be interchangeable.


