using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMOrderAutomation.Models
{
    public class OrderDetail
    {
        public int orderDetailId { get; set; }
        public int quantity { get; set; }
        public Item item { get; set; }
        public int tax { get; set; }

        public OrderDetail(int orderDetailId, int quantity, Item item,int tax)
        {
            this.orderDetailId = orderDetailId;
            this.quantity = quantity;
            this.item = item;
            this.tax = tax;
        }

        public float calcSubTotal()
        {
            return this.item.getPriceForQuantity(this.quantity);
        }
        public float calcTax()
        {
            return this.item.getPriceForQuantity(this.quantity) * tax / 100;
        }

        public float calcWeight()
        {
            return this.item.getWeight() * this.quantity;
        }
    }
}
