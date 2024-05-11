# Decorator Design Pattern

The design pattern revolves around transforming immutable objects multiple times, and since all components belong to the same family, it creates a recursive composition. The resulting object will have a stack of all the functionality added by the applied wrappers.

It helps reduce the number of classes we have because we package the classes at runtime, rather than defining them specifically as separate files at compile time.
