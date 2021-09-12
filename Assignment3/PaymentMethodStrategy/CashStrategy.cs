using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.PaymentMethodStrategy
{
    public class CashStrategy :IPaymentMethod
    {
        public bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 500)
            {
                Console.WriteLine($"Paying {amount} using Cash Declined");
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Paying {amount} using Cash was Successful");
                Console.ResetColor();
                return true;
            }
        }
    }
}
