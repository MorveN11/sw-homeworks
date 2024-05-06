# Template Method Report

## What I learned?

The template method pattern is a behavioral design pattern that defines the
skeleton of an algorithm in the superclass but lets subclasses override specific
steps of the algorithm without changing its structure. This pattern is useful
when you have an algorithm that has multiple steps, and you want to let
subclasses implement specific steps of the algorithm.

The template method pattern works with inheritance, meaning that the superclass
has a method that defines the algorithm's structure. This method calls abstract
methods that subclasses implement. This allows subclasses to implement specific
steps of the algorithm without changing the algorithm's structure.
