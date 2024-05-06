# Strategy Design Pattern

## What I learned?

The strategy pattern is a behavioral design pattern that allows you to define a
family of algorithms, encapsulate each one of them, and make them
interchangeable. The strategy pattern lets the algorithm vary independently from
the context that uses it. It is useful when you have a class that has multiple
behaviors and wants to switch between them at runtime.

The strategy pattern works with composition, meaning that the context class has
a reference to the strategy interface. The context class can then delegate the
behavior to the strategy interface. This allows the context class to switch
between different strategies at runtime.
