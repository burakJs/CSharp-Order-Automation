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
    public partial class UserHomePage : Form
    {
        public UserHomePage()
        {
            InitializeComponent();
        }

        private void userList_Click(object sender, EventArgs e)
        {
            // fill txtbox
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            View.BasketDetailPage basketDetailPage = new View.BasketDetailPage();
            basketDetailPage.ShowDialog();
            this.Close();
        }
    }
}
