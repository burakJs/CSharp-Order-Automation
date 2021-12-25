using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGMOrderAutomation.View
{
    public partial class CreditPaymentPage : Form
    {
        public CreditPaymentPage(Models.Order order)
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            View.BasketDetailPage basketDetailPage = new BasketDetailPage();
            basketDetailPage.ShowDialog();
            this.Close();
        }

        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            Models.User user = Models.User.getLoginedUser();
            Models.Order order = Models.Order.getUserOrder(user.memberId);
            string strDate = comboBox2.Text + "-" + comboBox1.Text + "-01";
            DateTime dateTime = Convert.ToDateTime(strDate);
            Models.Credit credit = new Models.Credit(txtCardNumber.Text, (Models.CreditType)comboCardType.SelectedIndex, dateTime, order.calcTotal());
            if (credit.authorized())
            {
                credit.orderComplete(order);
                user.updateUserTotalShopping(order.calcTotal());
                this.Hide();
                View.UserHomePage userHomePage = new View.UserHomePage();
                userHomePage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill blanks with right data");
            }
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            string strDate = comboBox2.Text + "-" + comboBox1.Text + "-01";
            DateTime dateTime = Convert.ToDateTime(strDate);
            Models.Order order = Models.Order.getUserOrder(Models.User.getLoginedUser().memberId);
            Models.Credit credit = new Models.Credit(txtCardNumber.Text, (Models.CreditType)comboCardType.SelectedIndex, dateTime, order.calcTotal());
            lblVerified.Text = credit.authorized() ? "Verified" : "Not Verified";
        }

        private void CreditPaymentPage_Load(object sender, EventArgs e)
        {
            lblTotalPrice.Text = Models.Order.getUserOrder(Models.User.getLoginedUser().memberId).calcTotal().ToString() + " $";
        }
    }
}
