using TransactionDemo;

var processor = new TransactionProcessor();

processor.Process("Alice", "Bob", 100.00m);
Console.WriteLine();
processor.Process("Alice", "Bob", -50.00m);
Console.WriteLine();
processor.Process("Alice", "Alice", 25.00m);
