using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMOrderAutomation.Models
{
    public class Check:Payment
    {
        public string name { get; set; }
        public string bankID { get; set; }
        public Check(string name, string bankID, int amount)
        {
            this.name = name;
            this.bankID = bankID;
            this.amount = amount;
        }
        public bool authorized()
        {
            return bankID.Length > 5;
        }
        public override int paymentMethod()
        {
            return Convert.ToInt32(PaymentMethod.CHECK);
        }
    }
}
