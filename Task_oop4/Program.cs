namespace Task_oop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod[] payments =
            {
                new CreditCardPayment(1500m),
                new CashPayment(300m),
                new CreditCardPayment(2506m),
            };
            -
            foreach (PaymentMethod payment in payments)
            {
                payment.Pay();

                payment.PrintReceipt();

                if (payment is IRefundable refundable)
                {
                    refundable.Refund();
                }

                Console.WriteLine();
            }
        }
    }
}
