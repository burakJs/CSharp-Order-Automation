using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BGMOrderAutomation.View
{
    public partial class BasketDetailPage : Form
    {
        private List<Models.OrderDetail> orderDetails;
        private Models.Order order;
        private Models.User loginedUser;
        public BasketDetailPage()
        {
            InitializeComponent();
        }


        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            if(radioCredit.Checked)
            {
                this.Hide();
                View.CreditPaymentPage creditPaymentPage = new View.CreditPaymentPage();
                creditPaymentPage.ShowDialog();
                this.Close();
            }
            if (radioCheck.Checked)
            {
                this.Hide();
                View.CheckPaymentPage checkPaymentPage = new View.CheckPaymentPage();
                checkPaymentPage.ShowDialog();
                this.Close();
            }
            if (radioCash.Checked)
            {
                MessageBox.Show("Purchased Successfully with Cash Payment", "Purchase Process", MessageBoxButtons.OK);
            }
        }
        private void getOrder()
        {
            Models.User user = new Models.User();
            loginedUser = Models.User.getLoginedUser();
            Models.Constant.connect.Open();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Models.Constant.connect,
                CommandText = "SELECT * FROM Orders where order_state=@state AND order_owner_id=@ownerId"
            };
            cmd.Parameters.AddWithValue("@state", (int)Models.OrderState.WAITING);
            cmd.Parameters.AddWithValue("@ownerId", loginedUser.memberId);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                order = new Models.Order(
                    (int)reader["order_id"],
                    (DateTime)reader["order_date"],
                    (Models.OrderState)reader["order_state"],
                    (int)reader["order_owner_id"],
                    new List<Models.OrderDetail>(),
                    new Models.Cash(0)
                );
            }
            else
            {
                Console.WriteLine("BOŞ DATA");
            }
            
            Models.Constant.connect.Close();
        }
        private void BasketDetailPage_Load(object sender, EventArgs e)
        {
            getOrder();
            float subTotal = 0;
            float totalTax = 0;
            orderDetails = new Models.OrderDetail().getOrderDetails(order.orderId);
            if (orderDetails.Count == 0)
            {
                MessageBox.Show("BOŞ");
            }
            foreach (Models.OrderDetail od in orderDetails)
            {
                string[] columns = { od.item.id.ToString(), od.item.name, "%" + od.item.tax.ToString(), od.quantity.ToString(), od.item.getPriceForQuantity(od.quantity).ToString() };
                var listItem = new ListViewItem(columns);
                orderDetailList.Items.Add(listItem);
                subTotal += od.calcSubTotal();
                totalTax += od.calcTax();
                od.orderId = this.order.orderId;
                this.order.orderDetails.Add(od);
                
               
            }

            lblSubTotal.Text = subTotal.ToString("n2").Trim() + " $";
            lblTotalTax.Text = totalTax.ToString("n2").Trim() + " $";
            lblTotalPrice.Text = (subTotal + totalTax).ToString("n2").Trim() + " $";
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            View.UserHomePage userHomePage = new UserHomePage();
            userHomePage.ShowDialog();
            this.Close();
        }
    }
}
