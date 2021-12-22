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
    public partial class CustomerRegisterPage : Form
    {
        public CustomerRegisterPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            View.CustomerHomePage customerHomePage = new View.CustomerHomePage();
            customerHomePage.ShowDialog();
            this.Close();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Models.Item item = new Models.Item(1, txtName.Text, Convert.ToInt32(maskedTextBox1.Text), float.Parse(maskedTextBox2.Text), 1, float.Parse(txtWeight.Text), Convert.ToInt32(txtTax.Text));
            item.addItem();
        }
    }
}
