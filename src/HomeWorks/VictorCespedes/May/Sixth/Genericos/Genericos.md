## Gnerics
They allow you to write classes, structures, methods and delegates that work with specific types, but without specifying them in a concrete way. In other words, they allow you to create reusable components that can work with different data types.

Before the introduction of generics in C# 2.0, if you wanted to create a collection that could contain different data types, such as integers, strings, etc., you would have to use the Object class and do type conversions (casting) when retrieving elements from the collection. 

You can define classes and methods that operate on specific types, but without specifying them directly. This allows you to write safer code, since type errors are detected at compile time instead of run time, and also improves performance by eliminating the need for type conversions.