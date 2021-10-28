# `using` vs `try-finally`

## Preparation Recipe

- Create a C# Class Library project.
- Choose a disposable class to use in the demo. For example `StreamWriter`.
- In the `Class1` class, create three methods:
  - `Method1`: Instantiate the `StreamWriter` and disposes it with a `try-finally` block.
  - `Method2`: Instantiate the `StreamWriter` and dispose it with a `using` block.
  - `Method3`: Instantiate the `StreamWriter` and disposes it with a `using` declaration. (C# 8.0)
- Build the project in release mode.
- Decompile the assembly using ILDASM tool.
- Highlight that the two methods are identical. With the exception of the name :)
  - Online tool may be used for comparison: https://text-compare.com/

