## Builder Pattern Dessign

This pattern is used to build complex objects step by step. It provides a flexible way to create objects, allowing the construction of different representations of the same object using the same construction steps.

The Builder pattern is used when the creation of an object is too complicated to be done in a single step or when you want to have a clear separation between the construction of an object and its representation.

It consists of a Builder interface and one or more concrete implementations of this interface. The Builder class defines methods to configure the different aspects of the object being built. Then, a Director class (optional) may use a Builder object to orchestrate the construction steps. Finally, a Builder method is called on the Builder to obtain the final object.