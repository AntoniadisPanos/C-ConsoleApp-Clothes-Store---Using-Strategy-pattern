using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Enums;
using Assignment3.EShopContext;
using Assignment3.Models;
using Assignment3.PaymentMethodStrategy;
using Assignment3.VariationStrategy;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Katastimatarxis

            IEnumerable<IVariationStrategy> ShopNormalVariation = new List<IVariationStrategy>()
            {
                new ColorVariationNormalStrategy(),
                new SizeVariationNormalStrategy(),
                new FabricVariationNormalStrategy()
            };


            IEnumerable<IVariationStrategy> ExpensiveVariation = new List<IVariationStrategy>()
            {
                new FabricVariationExpensiveStrategy()
            };


            //To Input logic //Creation Logic
            Console.WriteLine("Hello Client!");
            Console.WriteLine("Create TShirt");



            //Logic Color--------------------------------------
            Console.WriteLine("Choose Color");

            int colorInput;

            Color finalColor;

            var colors = Enum.GetNames(typeof(Color));
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"{i,-5}{colors[i]}");
            }

            colorInput = Convert.ToInt32(Console.ReadLine());   //ARITHMO

            finalColor = (Color)(colorInput);

            Console.WriteLine(finalColor);


            //Logic Fabric--------------------------------------
            Console.WriteLine("Choose Linen");

            int fabricInput;

            Fabric finalFabric;

            var fabrics = Enum.GetNames(typeof(Fabric));
            for (int i = 0; i < fabrics.Length; i++)
            {
                Console.WriteLine($"{i,-5}{fabrics[i]}");
            }

            fabricInput = Convert.ToInt32(Console.ReadLine());   //ARITHMO

            finalFabric = (Fabric)(fabricInput);

            Console.WriteLine(finalFabric);

            //Logic Size--------------------------------------
            Console.WriteLine("Choose Size");

            int sizeInput;

            Size finalSize;

            var sizes = Enum.GetNames(typeof(Size));
            for (int i = 0; i < sizes.Length; i++)
            {
                Console.WriteLine($"{i,-5}{sizes[i]}");
            }

            sizeInput = Convert.ToInt32(Console.ReadLine());   //ARITHMO

            finalSize = (Size)(sizeInput);

            Console.WriteLine(finalSize);




            TShirt tshirt = new TShirt(finalColor,finalSize,finalFabric);

            Console.WriteLine("Choose Payment");
            Console.WriteLine("1 - Debit");
            Console.WriteLine("2 - Bank");
            Console.WriteLine("3 - Cash");

            string paymentInput = Console.ReadLine();


            IPaymentMethod UserPaymentMethod;
            switch (paymentInput)
            {
                case "1": UserPaymentMethod = new DebitStrategy(); break;
                case "2": UserPaymentMethod = new BankTransferStrategy(); break;
                case "3": UserPaymentMethod = new CashStrategy(); break;
                default: UserPaymentMethod = new CashStrategy(); break;
            }


          



            var eshop = new EShop();
            eshop.SetVariation(ExpensiveVariation);
            eshop.SetPaymentMethod(UserPaymentMethod);


            eshop.PayTShirt(tshirt);




        }


    }





}
