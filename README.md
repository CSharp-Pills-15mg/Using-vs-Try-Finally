# `using` vs `try-finally`

## Problem Description

**Manually call `Dispose`**

If an object implements the `IDiposable` interface it is is, usually, a good practice to manually call its `Display` method as soon as the application does not need that object anymore. There are two main ways to do this:

- explicitly - Actually call the `Dispose` method.
- implicitly - Use a `using` block or a `using` declaration.

**Question**

Is there a functional difference between the `using` block, a `using` declaration and a `try-finally` block?