using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BGMOrderAutomation.Models
{
    public class OrderDetail
    {
        public int orderDetailId { get; set; }
        public int quantity { get; set; }
        public Item item { get; set; }
        public int tax { get; set; }
        public int orderId { get; set; }

        public OrderDetail(int orderDetailId, int quantity, Item item,int tax, int orderId)
        {
            this.orderDetailId = orderDetailId;
            this.quantity = quantity;
            this.item = item;
            this.tax = tax;
            this.orderId = orderId;
        }
        public OrderDetail()
        {

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

        public void createOrderDetail(int orderDetailId)
        {
            Constant.connect.Open();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM OrderDetails WHERE order_detail_item_id=@order_detail_item_id AND order_id=@order_id"
            };
            cmd.Parameters.AddWithValue("@order_detail_item_id", item.id);
            cmd.Parameters.AddWithValue("@order_id", orderId);
            SqlDataReader reader = cmd.ExecuteReader();
            bool result = reader.Read();
            quantity += result ? (int)reader["order_detail_quantity"] : 0;
            Constant.connect.Close();

            
            
            if (!result)
            {
                SqlParameter[] parameters = new SqlParameter[]{
                    new SqlParameter("@order_detail_quantity",quantity),
                    new SqlParameter("@order_detail_item_id",item.id),
                    new SqlParameter("@order_detail_tax",tax),
                    new SqlParameter("@order_id",orderId),
                };
                string commandText = "INSERT INTO OrderDetails(order_detail_quantity,order_detail_item_id,order_detail_tax,order_id) VALUES(@order_detail_quantity, @order_detail_item_id, @order_detail_tax,@order_id)";
                SQLManager.add(parameters, commandText);

            }
            else
            {
                SqlParameter[] parameters = new SqlParameter[]{
                    new SqlParameter("@order_detail_quantity",quantity),

                };
                string commandText = "UPDATE OrderDetails SET order_detail_quantity=@order_detail_quantity WHERE order_detail_item_id=" + item.id;
                SQLManager.add(parameters, commandText);
            }
            
            
        }

        public List<OrderDetail> getOrderDetails(int orderId)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM OrderDetails INNER JOIN Items ON OrderDetails.order_detail_item_id = Items.id WHERE OrderDetails.order_id = " + orderId.ToString()
            };
            Constant.connect.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Item item = new Item((int)reader["id"],
                                reader["item_name"].ToString(),
                                (int)reader["item_quantity"],
                                float.Parse(reader["item_price"].ToString()),
                                (int)reader["company_id"],
                                float.Parse(reader["weight"].ToString()),
                                (int)reader["tax"]
                            );
                    OrderDetail orderDetail = new OrderDetail(
                        (int)reader["order_detail_id"],
                        (int)reader["order_detail_quantity"],
                        item,
                        (int)reader["order_detail_tax"],
                        (int)reader["order_id"]
                        );
                    orderDetails.Add(orderDetail);
                }

                Constant.connect.Close();
            }
            return orderDetails;
        }
    }
}
