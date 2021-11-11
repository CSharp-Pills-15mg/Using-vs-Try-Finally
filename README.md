# `using` vs `try-finally`

## Pill Category

Language (C#)

## Description

**Manually call `Dispose`**

If an object implements the `IDiposable` interface, it is, usually, a good practice to manually call its `Dispose` method as soon as the application does not need that object anymore. There are two main ways to do this:

- explicitly - Actually call the `Dispose` method. Most suggested in a try-finally block.
- implicitly - Use a `using` block or a `using` declaration.

## Question

- Is there a functional difference between the `using` block, the `using` declaration and a `try-finally` block?

## Donations

> If you like my work and want to support me, you can buy me a coffee:
>
> [![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/Y8Y62EZ8H)

