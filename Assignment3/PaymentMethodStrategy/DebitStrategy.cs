using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.PaymentMethodStrategy
{
   public class DebitStrategy :IPaymentMethod
    {
        public bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 5000)
            {
                Console.WriteLine($"Paying {amount} using Debit Card Declined");
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Paying {amount} using Debit Card was Successful");
                Console.ResetColor();
                return true;
            }
        }
    }
}
