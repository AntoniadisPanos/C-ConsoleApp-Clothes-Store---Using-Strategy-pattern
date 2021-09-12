using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.PaymentMethodStrategy
{
    public interface IPaymentMethod
    {
        bool Pay(decimal amount);

    }
}
