using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMOrderAutomation.Models
{
    public class Cash : Payment
    {
        public override int paymentMethod()
        {
            return Convert.ToInt32(PaymentMethod.CASH);

        }
    }
}

