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
    public partial class CustomersUsersDetails : Form
    {
        private String name;
        public CustomersUsersDetails(String name)
        {
            this.name = name;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            View.CustomerHomePage customerHomePage = new View.CustomerHomePage();
            customerHomePage.ShowDialog();
            this.Close();
        }

        private void CustomersUsersDetails_Load(object sender, EventArgs e)
        {
            lblUserName.Text = name;
        }
    }
}
