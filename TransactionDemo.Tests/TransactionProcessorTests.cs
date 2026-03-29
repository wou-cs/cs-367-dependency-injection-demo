using System;
using TransactionDemo;

namespace TransactionDemo.Tests
{
    public class TestLogger : ILogger
    {
        private string _lastMessage;

        public void Log(string message)
        {
            _lastMessage = message;
        }

        public string GetLastMessage()
        {
            return _lastMessage;
        }
    }
    public class TransactionProcessorTests
    {
        [Fact]
        void Process_ForValidTransaction_LogsSuccess()
        {
            // Arrange
            var logger = new TestLogger();
            var processor = new TransactionProcessor(logger);

            // Act
            processor.Process("Alice", "Bob", 100.00m);

            // Assert
            Assert.Contains("complete", logger.GetLastMessage());
        }
    }
}