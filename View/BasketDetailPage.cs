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

            Models.Cash cash = new Models.Cash(order.calcTotal());
            Models.User user = Models.User.getLoginedUser();

            if(radioCredit.Checked)
            {
                this.Hide();
                View.CreditPaymentPage creditPaymentPage = new View.CreditPaymentPage(order);
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
                cash.orderComplete(order);
                user.updateUserTotalShopping(order.calcTotal());
                this.Hide();
                View.UserHomePage userHomePage = new View.UserHomePage();
                userHomePage.ShowDialog();
                this.Close();
            }
        }
        private void getOrder()
        {
            loginedUser = Models.User.getLoginedUser();

            order = Models.Order.getUserOrder(loginedUser.memberId);
            
        }
        private void BasketDetailPage_Load(object sender, EventArgs e)
        {
            getOrder();
            float subTotal = 0;
            float totalTax = 0;
            orderDetails = new Models.OrderDetail().getOrderDetails(order.orderId);
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
            lblTotalPrice.Text = (subTotal + totalTax).ToString().Trim() + " $";
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            View.UserHomePage userHomePage = new UserHomePage();
            userHomePage.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Models.OrderDetail od in orderDetails)
            {
                od.deleteOrderDetail();
            }

            order.deleteOrder();
            this.Hide();
            View.UserHomePage userHomePage = new View.UserHomePage();
            userHomePage.ShowDialog();
            this.Close();
        }
    }
}
