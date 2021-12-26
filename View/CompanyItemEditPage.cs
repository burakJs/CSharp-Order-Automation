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
    public partial class CompanyItemEditPage : Form
    {
        private Models.Item item;
        public CompanyItemEditPage(Models.Item item)
        {
            this.item = item;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            View.CustomerItemsPage customerItemsPage = new View.CustomerItemsPage();
            customerItemsPage.ShowDialog();
            this.Close();
        }

        private void CompanyItemEditPage_Load(object sender, EventArgs e)
        {
            txtItemID.Text = this.item.id.ToString();
            txtItemName.Text = this.item.name;
            txtItemQuantity.Text = this.item.quantity.ToString();
            txtItemPrice.Text = this.item.price.ToString();
            txtTax.Text = this.item.tax.ToString();
            txtWeight.Text = this.item.weight.ToString();
            
        }

        private void btnViewAllItems_Click(object sender, EventArgs e)
        {
            Models.Item item = new Models.Item(
                    this.item.id,
                    txtItemName.Text,
                    Convert.ToInt32(txtItemQuantity.Text),
                    float.Parse(txtItemPrice.Text),
                    this.item.companyId,
                    float.Parse(txtWeight.Text),
                    Convert.ToInt32(txtTax.Text)
                );

            item.updateItem();
            this.Hide();
            View.CustomerHomePage customerHomePage = new View.CustomerHomePage();
            customerHomePage.ShowDialog();
            this.Close();

        }
    }
}
