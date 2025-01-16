public class TransactionService
{
    private List<Transaction> transactions = new List<Transaction>();

    public List<Transaction> GetTransactions() => transactions;

    public void SaveTransaction(Transaction transaction)
    {
        // Add the new transaction to the list
        transactions.Add(transaction);
    }
}
