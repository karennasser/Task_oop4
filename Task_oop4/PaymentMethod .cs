using System;
using System.Collections.Generic;
using System.Text;

namespace Task_oop4
{
    abstract class PaymentMethod
    {
        public decimal Amount { get; }
        protected PaymentMethod(decimal amount)
        {
            this.Amount = amount;
        }
        public void PrintReceipt()
        {
            Console.WriteLine(" Receipt:");
            Console.WriteLine($"Payment Type: {GetType().Name}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine("-------------------");
        }

        public abstract void Pay();

    }
}
