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
        public float weight { get; set; }

        public Item(int id, String name, int quantity, float price, int companyId, float weight)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.companyId = companyId;
            this.weight = weight;
        }

        public float getWeight()
        {
            return this.weight;
        }

        public float getPriceForQuantity(int quantity)
        {
            return this.price * quantity;
        }
    }
}
