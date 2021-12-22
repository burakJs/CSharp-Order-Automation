using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMOrderAutomation.Models
{
    public enum CreditType
    {
        CREDİT,
        BANK
    }
    public class Credit:Payment
    {
        public string number { get; set; }
        public CreditType type { get; set; }
        public DateTime exDate { get; set; }

        public bool authorized()
        {
            return this.number.Length == 16;
        }
        public override int paymentMethod()
        {
            return Convert.ToInt32(PaymentMethod.CREDİT);

        }
    }
}
