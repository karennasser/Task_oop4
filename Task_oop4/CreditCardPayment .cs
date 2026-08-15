using System;
using System.Collections.Generic;
using System.Text;

namespace Task_oop4
{
    internal class CreditCardPayment: PaymentMethod, IRefundable
    {
        public CreditCardPayment(decimal amount) : base(amount) 
        {
          
        }
        public override void Pay()
        {
            Console.WriteLine($"Paid {Amount} with credit card.");
        }

        public void Refund()
        {
            Console.WriteLine($"Refunded {Amount} to the credit card.");
        }
    }
}
