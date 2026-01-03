using System;

namespace Solutions_MZ;

public static class Task13_SwitchStatements
{
    public interface IPaymentFeeStrategy
    {
        decimal DeterminePaymentFee(decimal amount);
    }

    public sealed class CreditCardFeeStrategy : IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount) => amount * 0.02m;
    }

    public sealed class PayPalFeeStrategy : IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount) => amount * 0.03m;
    }

    public sealed class BankTransferFeeStrategy : IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount) => amount * 0.01m;
    }

    public sealed class NoFeeStrategy : IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount) => 0m;
    }

    public sealed class Payment
    {
        private readonly IPaymentFeeStrategy _feeStrategy;

        //strategia wstrzyknięta (bez switch)
        public Payment(IPaymentFeeStrategy feeStrategy)
        {
            _feeStrategy = feeStrategy ?? throw new ArgumentNullException(nameof(feeStrategy));
        }

        public decimal DeterminePaymentFee(decimal amount) => _feeStrategy.DeterminePaymentFee(amount);
    }

    public static class PaymentFeeStrategyFactory
    {
        public static IPaymentFeeStrategy Create(string paymentMethod) =>
            paymentMethod switch
            {
                "CreditCard" => new CreditCardFeeStrategy(),
                "PayPal" => new PayPalFeeStrategy(),
                "BankTransfer" => new BankTransferFeeStrategy(),
                _ => new NoFeeStrategy()
            };
    }

    public static void Run()
    {
        Console.WriteLine("[13] Switch Statements (Strategy)");

        decimal amount = 1000m;

        var payment1 = new Payment(PaymentFeeStrategyFactory.Create("CreditCard"));
        Console.WriteLine($"CreditCard fee: {payment1.DeterminePaymentFee(amount)} (expected 20)");

        var payment2 = new Payment(PaymentFeeStrategyFactory.Create("PayPal"));
        Console.WriteLine($"PayPal fee: {payment2.DeterminePaymentFee(amount)} (expected 30)");

        var payment3 = new Payment(PaymentFeeStrategyFactory.Create("BankTransfer"));
        Console.WriteLine($"BankTransfer fee: {payment3.DeterminePaymentFee(amount)} (expected 10)");
    }
}
