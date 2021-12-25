using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMOrderAutomation.Models
{
    public enum CreditType
    {
        CREDIT,
        BANK
    }
    public class Credit:Payment
    {
        public string number { get; set; }
        public CreditType type { get; set; }
        public DateTime expDate { get; set; }

        public Credit(string number, CreditType type, DateTime expDate, float amount)
        {
            this.number = number;
            this.type = type;
            this.expDate = expDate;
            this.amount = amount;
        }
        public bool authorized()
        {
            return this.number.Length == 20;
        }
        public override int paymentMethod()
        {
            return Convert.ToInt32(PaymentMethod.CREDİT);

        }
    }
}
