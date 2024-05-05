# TEMPLATE AND STRATEGY DESIGN PATTERNS


## STRATEGY DESIGN PATTERN

The Strategy design pattern is a way to encapsulate repeated code with a simple variation in how something is done, reducing "if statements" and categorizing them through inheritance. This makes changing algorithms efficient at runtime, allowing users to switch them without much hassle. It even aids developers because adding a new algorithm becomes much easier, reducing the effort required to add one.

| The Strategy pattern relies on composition to use a strategy, but it uses association (inheritance) to encapsulate the strategies into one. |
| :---        |


## TEMPLATE DESIGN PATTERN

The Template method pattern defines an algorithm in terms of abstract operations or steps that their subsclasses override to provide concrete behavior, some operations have their by default behavior and are optional to override 


This pattern is typically used when there is a lot of repeated code with the same steps to resolve input or perform certain tasks and use if statements to  resolve them. 


| The Template Pattern relies on inheritance relationships between classes and utilizes polymorphism to allow for multiple behaviors. This is because a subclass may or may not implement certain methods defined in a skeleton class, thus inheriting behavior from the superclass.|
| :---        |



## Differences

#### Template

- We can customize steps within a set structure.
- It's like having a recipe where you can tweak some ingredients

#### Strategy

- We can switch between different algorithms (or strategies) entirely.
- It's like having a toolbox with various tools, and we can choose the right one for the task.


## Similarities

- Both keep the inside stuff hidden from the outside.
- Both allow us easy adjustments.
- Both simplify complex concepts into easier-to-understand representations.
