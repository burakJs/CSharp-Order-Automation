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
        private List<Models.OrderDetail> orderDetails;
        public BasketDetailPage(List<Models.OrderDetail> orderDetails)
        {
            InitializeComponent();
            this.orderDetails = orderDetails;
        }

        public BasketDetailPage() {
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

        private void BasketDetailPage_Load(object sender, EventArgs e)
        {
            float subTotal = 0;
            float totalTax = 0;
            foreach (Models.OrderDetail od in orderDetails)
            {
                string[] columns = { od.item.id.ToString(), od.item.name, "%" + od.item.tax.ToString(), od.item.quantity.ToString(), od.item.getPriceForQuantity(od.quantity).ToString() };
                var listItem = new ListViewItem(columns);
                orderDetailList.Items.Add(listItem);
                subTotal += od.calcSubTotal();
                totalTax += od.calcTax();
            }

            lblSubTotal.Text = subTotal.ToString("n2").Trim() + " $";
            lblTotalTax.Text = totalTax.ToString("n2").Trim() + " $";
            lblTotalPrice.Text = (subTotal + totalTax).ToString("n2").Trim() + " $";
            lblDate.Text = DateTime.Now.ToString("dd/mm/yyyy");
        }
    }
}
