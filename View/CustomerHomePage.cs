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

        private void userList_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = userList.SelectedItems[0];
            //MessageBox.Show(firstSelectedItem.SubItems[1].Text);
            this.Hide();
            View.CustomersUsersDetails customersUsersDetails = new View.CustomersUsersDetails(name: firstSelectedItem.SubItems[1].Text);
            customersUsersDetails.ShowDialog();
            this.Close();
        }

        private void btnViewAllItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerItemsPage customerItemsPage = new CustomerItemsPage();
            customerItemsPage.ShowDialog();
            this.Close();
        }
    }
}
