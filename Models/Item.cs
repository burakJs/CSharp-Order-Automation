using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMOrderAutomation.Models
{
    public class Item
    {
        public int id { get; set; }
        public String name { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public int companyId { get; set; }

        public Item(int id, String name, int quantity, float price, int companyId)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.companyId = companyId;
        }
    }
}
