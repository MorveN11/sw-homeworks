# <div align="center">DECORATOR DESIGN PATTERN</h1>

**Name:** Victor Alejandro Cespedes Cartagena

## DECORATOR DESIGN PATTERN
The Decorator design pattern belongs to the group of structural patterns. It allows additional behaviors to be dynamically attached to objects at runtime without altering their basic structure. This is achieved by creating a series of "decorators" that wrap the original object and provide additional functionality.

## Purpose
The main purpose of the Decorator pattern is to extend the functionality of objects in a flexible manner and without modifying their source code. It allows adding new responsibilities to individual objects independently and transparently to the client that uses them.

## Usage
When you want to add functionalities to objects in a dynamic and flexible way.
To avoid the complexity involved in creating subclasses for each combination of features.
When you need to extend an object with new functionalities without affecting other objects of the same class.
## Structure
The basic structure of the Decorator pattern includes:

Component: defines the common interface for the objects that can be decorated.

Concrete Component: Implements the Component interface by defining the basic object to which additional responsibilities can be added.

Decorator: Abstract class that implements the Component interface and has a reference to an object of the Component type. It contains methods to wrap and delegate calls to the Component object it wraps.

Concrete Decorators: They extend Decorator and add additional responsibilities to the Component. They can call methods of the base decorator and add their own logic.

## Advantages
Flexibility and Extensibility: Allows adding new functionalities dynamically and at runtime.
Complies with the Single Responsibility Principle: Each decorator is responsible for a single responsibility.
Reusability: Decorators can be combined and reused for different objects.

## Disadvantages
May increase complexity: By introducing multiple layers of decorator objects.
Possible object overload: If many decorators are used, there may be an increase in the number of objects created in memory.

## My code
ICharacter: Interface defining the operations characters can perform.
Player: Concrete component implementing ICharacter.
CharacterDecorator: Abstract class implementing ICharacter and holding a reference to another ICharacter.
ArmorDecorator and WeaponDecorator: Concrete decorators adding armor and weapon functionality to the player character.
