using TransactionDemo;

var logger = new ConsoleLogger();
var processor = new TransactionProcessor(logger);

processor.Process("Alice", "Bob", 100.00m);
Console.WriteLine();
processor.Process("Alice", "Bob", -50.00m);
Console.WriteLine();
processor.Process("Alice", "Alice", 25.00m);
