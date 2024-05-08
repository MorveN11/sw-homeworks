# Generics Report

## What I learned?

Generics in C# are a powerful feature that allows you to define type-safe data
structures, without committing to actual data types. This results in a
significant performance boost and better code reusability and type safety.
Generics allow you to write a class or method that can work with any data type.
You write the specifications for the class or the method, with placeholder type
parameters. The actual data types are specified when you instantiate the class
or call the method. This allows for a high level of code reusability without
sacrificing type safety.

Generics are most frequently used with collections and the methods that operate
on them. The System.Collections.Generic namespace contains several classes that
are designed to be used with generics. These classes, such as `List<T>`,
`Dictionary<TKey, TValue>`, `Queue<T>`, and `Stack<T>`, are much more efficient
than their non-generic counterparts in System.Collections. Generics can also be
used to define your own generic classes, interfaces, methods, events and
delegates. Constraints can be applied to generics to restrict the types that can
be used with them, providing even more control and safety.
