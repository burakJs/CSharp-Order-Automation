using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMOrderAutomation.Models
{
    public enum PaymentMethod
    {
        CASH,
        CHECK,
        CREDİT
    }

    public abstract class Payment
    {
        public int paymentId { get; set; }
        public decimal amount { get; set; }
        public abstract int paymentMethod();

    }
}
