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
    public partial class CustomerHomePage : Form
    {
        public CustomerHomePage()
        {
            InitializeComponent();
        }

        private void btnViewAllItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerItemsPage customerItemsPage = new CustomerItemsPage();
            customerItemsPage.ShowDialog();
            this.Close();
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {
            Models.Customer customer = Models.Customer.getLoginedCustomer();
            Models.Company company = Models.Company.getCompanyById(customer.companyId);
            lblCompanyName.Text = company.companyName;
            lblCustomerName.Text = customer.username;
            List<Models.User> users = Models.User.getAllUsers();

            foreach (Models.User user in users)
            {
                string[] columns = { user.memberId.ToString(), user.username, user.totalShopping.ToString() };
                var listItem = new ListViewItem(columns);
                userList.Items.Add(listItem);
            }
        }
    }
}
