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
    public partial class BasketDetailPage : Form
    {
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
    }
}
