using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        public float amount { get; set; }
        public abstract int paymentMethod();

        public void orderComplete(Order order)
        {
            Models.User user = Models.User.getLoginedUser();
            user.updateUserTotalShopping(order.calcTotal());
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@order_id",order.orderId),
                new SqlParameter("@order_state", (int)OrderState.DONE)
            };
            string commandText = "UPDATE Orders SET order_state = @order_state WHERE order_id = @order_id";
            SQLManager.runQuery(parameters, commandText);
        }
    }
}
