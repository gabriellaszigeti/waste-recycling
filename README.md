# Waste Recycling

## Story

It's 2020.
The mentors of Codecool Phnom Pen (capital of Cambodia) are fed up that despite the strict house rules, no one cares about recycling in the school.
They decided to create an automated dustbin which can detect different types of garbage, and place them in different containers automatically.

Mentors at Codecool usually have a whole bunch of things to do, and the ones here aren't exceptions either, so they don't have the time to implement the dustbin software.
Luckily, their internal computer is capable of running Java or C# programs...

Have you figured it out yet?
Yes! It's your job to implement it, in an object-oriented way!

## What are you going to learn?

- Use the basic mechanics of inheritance.
- Use arrays and make them grow in size dynamically.
- Inspect the runtime type of objects referenced by polymorphic references.
- Make decisions in your code based on the runtime type of an object.
- Throw exceptions to signal errors, bad usage from within methods, and to catch those in an outer scope.
- Allow objects to display textual information about themselves in an object-oriented way.
- Use access modifiers, such as `private` and `protected` to achieve data hiding and encapsulation.

## Tasks

1. Define the `Dustbin` class in an object-oriented way.
    - `Dustbin` instances can only be instantiated by supplying a color name.
    - `Dustbin` instances allow access to the color name with which they are created, using the get-only `Color` property.
    - `Dustbin` instances allow `Garbage` instances to be thrown into them using the `ThrowOutGarbage(Garbage)` method.
    - `Dustbin` instances only allow the following kinds of garbage to be thrown into them.
- Cleaned `PlasticGarbage` - Squeezed `PaperGarbage` - Any other kind of `Garbage` (such as house waste),
Otherwise, a `DustbinContentException` occurs.
    - `Dustbin` instances allow access to the number of different kinds of garbage stored in them, using the following properties.
- `HouseWasteCount` - `PaperCount` - `PlasticCount`
    - `Dustbin` instances provide a way to clear their contents, using the `EmptyContents()` method.
    - A `Dustbin` provides a way to get its textual representation, using the `ToString()` method. The representation is similar to the following example. ``` Green Dustbin! House waste content: 2 item(s)
    Rotten tomato nr.1
    Half-eaten lettuce nr.2
Paper content: 1 item(s)
    Failed exam nr.1
Plastic content: 3 item(s)
    Empty plastic bottle nr.1
    Plastic bag nr.2
    Wrapper foil nr.3
```
    - `Dustbin` instances provide the possibility to print their textual representation to the console, using the `DisplayContents()` method.

2. Define the `Garbage` class in a way that other garbage types can use it as their base/parent class, sharing as many behaviors between the parent and child as possible.
    - `Garbage` instances can only be instantiated by supplying a garbage name.
    - `Garbage` instances allow access to the name with which they are created, using the get-only `Name` property.

3. Define the `PlasticGarbage` class so that it reuses as many regular garbage behaviors as possible, and extends them with the notion of being *cleanable*.
    - `PlasticGarbage` instances can only be instantiated by supplying a garbage name and a flag that signals whether they are clean, in this order.
    - `PlasticGarbage` instances allow access to the name with which they are created, just like `Garbage` instances do.
    - `PlasticGarbage` instances allow checking whether they are clean, using the `Cleaned` property. The property has a private setter.
    - `PlasticGarbage` instances provide a way to clean them, using the `Clean()` method. If a piece of plastic garbage is already clean, using this method has no effect.

4. Define the `PaperGarbage` class in a way that it reuses as many regular garbage behaviors as possible, and extends them with the notion of being *squeezable*.
    - `PaperGarbage` instances can only be instantiated by supplying a garbage name and a flag that signals whether they are squeezed, in this order.
    - `PaperGarbage` instances allow access to the name they with which they are created, just like `Garbage` instances do.
    - `PaperGarbage` instances allow checking whether they are squeezed, using the `Squeezed` property. The property has a private setter.
    - `PaperGarbage` instances provide a way to squeeze them, using the `Squeeze()` method. If a piece of paper garbage is already squeezed, using this method has no effect.

5. In your `Main` class, write code that serves as a "movie script" for a little story. Think of the contents of the main method as series of things (statements) that happen over time in the life of an ordinary dustbin.
    - At least one `DustBin` instance is created. It can be named in any way.
    - At least one instance of each garbage subtype is created. These are stored in `Garbage` variables.
    - All created garbage is thrown into the `DustBin`.
    - A dirty piece of plastic garbage is created and thrown into the DustBin.
    - A dirty piece of plastic garbage is cleaned and thrown into the `DustBin`.
    - The bin content is written to the console.
    - The bin is emptied and its content is written to the console again.

## General requirements

- The program is compiled without errors and is executable.
- The code follows language-specific naming conventions.
- The program notifies the user when exceptional situations occur.

## Hints

- Make your life easy with formatted strings.
- Use simple arrays and resize them dynamically for different contents in the Dustbin.
- Use the `instanceof` operator to determine whether a variable is a particular type.

## Background materials

- <i class="far fa-exclamation"></i> [Arrays](project/curriculum/materials/pages/csharp/arrays.md)
- <i class="far fa-exclamation"></i> [OOP Basics](project/curriculum/materials/pages/csharp/basics-of-object-oriented-programming.md)
- <i class="far fa-exclamation"></i> [OOP Basics 2](project/curriculum/materials/pages/java/basics-of-object-oriented-programming-with-java-part-2.md)
- <i class="far fa-exclamation"></i> [Inheritance](project/curriculum/materials/pages/java/inheritance-java.md)
- <i class="far fa-exclamation"></i> [Polymorphism](project/curriculum/materials/pages/java/polymorphism.md)
- <i class="far fa-candy-cane"></i> [How do dynamic arrays work](https://www.geeksforgeeks.org/how-do-dynamic-arrays-work/)
- <i class="far fa-video"></i> <i class="far fa-book-open"></i> [Interpolated string in C#](https://www.youtube.com/watch?v=uQAjJoWRFCI)

