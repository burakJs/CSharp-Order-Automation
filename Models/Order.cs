using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        public int ownerOrderId { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
        public Payment payment { get; set; }

        public Order(int orderId, DateTime date, OrderState state, int ownerOrderId, List<OrderDetail> orderDetails, Payment payment)
        {
            this.orderId = orderId;
            this.date = date;
            this.state = state;
            this.ownerOrderId = ownerOrderId;
            this.orderDetails = orderDetails;
            this.payment = payment;
        }

        public float calcTax()
        {
            float total = 0f;
            foreach (OrderDetail orderDetail in orderDetails)
            {
                total += orderDetail.calcTax();
            }
            return total;
        }

        public float calcTotal()
        {
            float total = 0f;
            foreach (OrderDetail orderDetail in orderDetails)
            {
                total += orderDetail.calcSubTotal();
            }
            return total;
        }

        public float calcTotalWeight()
        {
            float total = 0f;
            foreach (OrderDetail orderDetail in orderDetails)
            {
                total += orderDetail.calcWeight();
            }
            return total;
        }

        public void changeOrderState(OrderState state)
        {
            this.state = state;
        }

        public void addOrder(int orderId)
        {
            Constant.connect.Open();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM Orders WHERE order_id=@order_id "
            };
            cmd.Parameters.AddWithValue("@order_id", orderId);
            SqlDataReader reader = cmd.ExecuteReader();
            bool result = reader.Read();
            Constant.connect.Close();

            if (!result)
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@order_id", orderId),
                    new SqlParameter("@order_date", date),
                    new SqlParameter("@order_state", ((int)state)),
                    new SqlParameter("@order_owner_id", ownerOrderId),
                    new SqlParameter("@paymentId", payment.paymentMethod())
                };
                string commandText = "INSERT INTO Orders(order_date, order_state, order_owner_id,payment_id) VALUES(@order_date, @order_state, @order_owner_id, @paymentId);";
                SQLManager.runQuery(parameters, commandText);
            }
        }
        
        static public Order getUserOrder(int userId)
        {
            Order order;
            Constant.connect.Open();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM Orders where order_state=@order_state AND order_owner_id=@order_owner_id"
            };
            cmd.Parameters.AddWithValue("@order_state", (int)Models.OrderState.WAITING);
            cmd.Parameters.AddWithValue("@order_owner_id", userId);
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                order = new Order(
                    (int)reader["order_id"],
                    (DateTime)reader["order_date"],
                    (OrderState)reader["order_state"],
                    (int)reader["order_owner_id"],
                    new List<OrderDetail>(),
                    new Cash(0)
                );
            }
            else
            {

                order = new Order(1, DateTime.Now, OrderState.WAITING, userId, new List<OrderDetail>(), new Cash(0));
            }
            Constant.connect.Close();
            return order;
        }
    
        public void deleteOrder()
        {
            string commandText = "DELETE FROM Orders WHERE order_id = " + orderId.ToString();
            SqlParameter[] parameters = new SqlParameter[] { };
            SQLManager.runQuery(parameters, commandText);
        }
    }
}
