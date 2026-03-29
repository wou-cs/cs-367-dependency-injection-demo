namespace TransactionDemo;

public class TransactionProcessor
{
    private readonly ILogger _logger;

    public TransactionProcessor(ILogger logger)
    {
        _logger = logger;
    }

    public bool Process(string from, string to, decimal amount)
    {
        _logger.Log($"Starting transaction: {from} -> {to} for {amount:C}");

        if (amount <= 0)
        {
            _logger.Log("Transaction failed: amount must be positive");
            return false;
        }

        if (from == to)
        {
            _logger.Log("Transaction failed: sender and receiver must be different");
            return false;
        }

        _logger.Log("Transaction complete");
        return true;
    }
}
