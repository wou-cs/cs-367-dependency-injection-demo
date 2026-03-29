# Dependency Injection Demo - TransactionProcessor

Screencast demo for CS 367, Week 02. Accompanies the Dependency Injection presentation.

## What This Demonstrates

A `TransactionProcessor` class validates and logs financial transactions. The demo walks through refactoring from a hard dependency on `ConsoleLogger` to constructor injection via an `ILogger` interface, motivated by the need to write testable code.

### Progression

1. **Start** - `TransactionProcessor` creates its own `ConsoleLogger` with `new`. Works fine at runtime, but impossible to test without console side effects.
2. **Extract interface** - Introduce `ILogger` and have `ConsoleLogger` implement it.
3. **Constructor injection** - `TransactionProcessor` accepts an `ILogger` parameter instead of creating its own.
4. **Test** - Create a `TestLogger` double that captures log messages, inject it in tests, and assert against the captured output.

## Project Structure

```
TransactionDemo/             Console application
  ConsoleLogger.cs           Concrete logger (writes timestamped output to console)
  ILogger.cs                 Interface extracted during the demo
  TransactionProcessor.cs    Validates transactions and logs results
  Program.cs                 Composition root - wires dependencies manually

TransactionDemo.Tests/       xUnit test project
  TransactionProcessorTests.cs   Tests using a TestLogger double
```

## Running

```bash
dotnet run --project TransactionDemo
dotnet test
```
