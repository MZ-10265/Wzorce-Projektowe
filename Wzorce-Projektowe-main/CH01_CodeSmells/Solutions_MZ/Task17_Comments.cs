using System;

namespace Solutions_MZ;

public static class Task17_Comments
{
    public sealed class Transaction
    {
        public bool VerifyDetails()
        {
            return true;
        }
    }

    public sealed class PaymentProcessor
    {
        public void PerformTransaction(Transaction transaction)
        {
            if (!AreTransactionDetailsValid(transaction))
                return;

            ExecutePayment(transaction);
            ApplyAccountUpdates(transaction);
            IssueReceipt(transaction);
        }

        private bool AreTransactionDetailsValid(Transaction transaction)
        {
            return transaction.VerifyDetails();
        }

        private void ExecutePayment(Transaction transaction)
        {
            ProcessPayment(transaction);
        }

        private void ApplyAccountUpdates(Transaction transaction)
        {
            UpdateAccount(transaction);
        }

        private void IssueReceipt(Transaction transaction)
        {
            CreateReceipt(transaction);
        }

        private void ProcessPayment(Transaction transaction)
        {
            Console.WriteLine("Payment processed.");
        }

        private void UpdateAccount(Transaction transaction)
        {
            Console.WriteLine("Account updated.");
        }

        private void CreateReceipt(Transaction transaction)
        {
            Console.WriteLine("Receipt created.");
        }
    }

    public static void Run()
    {
        Console.WriteLine("[17] Comments");

        var processor = new PaymentProcessor();
        processor.PerformTransaction(new Transaction());

        Console.WriteLine("Expected: Payment processed -> Account updated -> Receipt created");
    }
}
