using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Models;
using Assignment3.PaymentMethodStrategy;
using Assignment3.VariationStrategy;

namespace Assignment3.EShopContext
{
    public class EShop
    {
        private IEnumerable<IVariationStrategy> Variations { get; set; }

        private IPaymentMethod PaymentMethod { get; set; }

        public void SetVariation(IEnumerable<IVariationStrategy> variations)
        {
            Variations = variations;
        }

        public void SetPaymentMethod(IPaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }





        public void PayTShirt(TShirt tshirt)
        {
            Console.WriteLine("\t\t T-Shirt Payment Progress...");

            foreach (var variation in Variations)
            {
                variation.Cost(tshirt);
            }

            Console.WriteLine($"T-Shirt Final Price is {tshirt.Price} euros");

            PaymentMethod.Pay(tshirt.Price);

        }






    }
}
