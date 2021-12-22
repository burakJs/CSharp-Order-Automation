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
        private String id;
        private String name;
        private String quantity;
        private String price;
        public CompanyItemEditPage(String id, String name, String quantity, String price)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
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
            txtItemID.Text = this.id;
            txtItemName.Text = this.name;
            txtItemQuantity.Text = this.quantity;
            String defaultMask = "00";
            for(int i = 0; i<this.price.Length - 5; i++)
            {
                defaultMask += "0";
            }
            defaultMask += ",00";
            txtItemPrice.Mask = defaultMask;
            txtItemPrice.Text = this.price;
        }
    }
}
