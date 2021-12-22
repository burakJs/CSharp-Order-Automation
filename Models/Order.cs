using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMOrderAutomation.Models
{
    public enum OrderState
    {
        WAITING, DONE, CANCEL
    }
    public class Order
    {
        public int orderId { get; set; }
        public DateTime date { get; set; }
        public OrderState state { get; set; }
        public String ownerOrder { get; set; }
        public List<String> orderDetails { get; set; }
        public int payment { get; set; }

        public Order(int orderId, DateTime date, OrderState state, String ownerOrder, List<String> orderDetails, int payment)
        {
            this.orderId = orderId;
            this.date = date;
            this.state = state;
            this.ownerOrder = ownerOrder;
            this.orderDetails = orderDetails;
            this.payment = payment;
        }

        public float calcTax()
        {
            return 0;
        }

        public float calcTotal()
        {
            return 0;
        }

        public float calcTotalWeight()
        {
            return 0;
        }

        public void changeOrderState(OrderState state)
        {
            this.state = state;
        }
    }
}
