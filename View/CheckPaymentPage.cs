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
    }
}
