# `using` vs `try-finally`

## Category

Language (C#)

## Description

- Q: Is the `using` block just a syntactic sugar for a `try-finally` block?
- A: Yes.
  - Use ILDASM to highlight that the two blocks are translated into identical IL code.

## Recipe

- Create a C# Class Library project.
- Create a class that implements `IDisposable` interface:
  - `DisposableClass`
- In the `Program` class, create three methods:
  - `Method1`: Instantiate the `DisposableClass` and dispose it with a `using` block.
  - `Method2`: Instantiate the `DisposableClass` and disposes it with a `using` declaration.
  - `Method3`: Instantiate the `DisposableClass` and disposes it with a `try-finally` block.
- Build the project in release mode.
- Decompile the assembly using ILDASM tool.
- Highlight that the two methods are identical. With the exception of the name :)