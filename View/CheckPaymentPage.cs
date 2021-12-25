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
    public partial class CheckPaymentPage : Form
    {
        public CheckPaymentPage()
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
            Models.Check check = new Models.Check(txtName.Text, txtBankID.Text, 0);
            if (check.authorized())
            {
                check.orderComplete(order);
                user.updateUserTotalShopping(order.calcTotal());
                this.Hide();
                View.UserHomePage userHomePage = new View.UserHomePage();
                userHomePage.ShowDialog();
                this.Close();
            }
        }

        private void txtBankID_TextChanged(object sender, EventArgs e)
        {
            Models.Check check = new Models.Check(txtName.Text, txtBankID.Text, 0);
            lblVerified.Text = check.authorized() ? "Verified" : "Not Verified"; 
        }

        private void CheckPaymentPage_Load(object sender, EventArgs e)
        {
            lblTotalPrice.Text = Models.Order.getUserOrder(Models.User.getLoginedUser().memberId).calcTotal().ToString() + " $";
        }
    }
}
