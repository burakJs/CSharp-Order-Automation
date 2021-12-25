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
    public partial class CustomerItemsPage : Form
    {
        List<Models.Item> items;
        public CustomerItemsPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHomePage customerHomePage = new CustomerHomePage();
            customerHomePage.ShowDialog();
            this.Close();
        }

        private void companyItemList_DoubleClick(object sender, EventArgs e)
        {
            var firstSelectedItem = companyItemList.SelectedItems[0];
            //MessageBox.Show(firstSelectedItem.SubItems[1].Text);
            this.Hide();
            View.CompanyItemEditPage companyItemEditPage = new View.CompanyItemEditPage(
                    items[firstSelectedItem.Index]
                ) ;
            companyItemEditPage.ShowDialog();
            this.Close();
        }

        private void CustomerItemsPage_Load(object sender, EventArgs e)
        {
            Models.Customer customer = Models.Customer.getLoginedCustomer();
            items = Models.Item.getAllItemsByCompanyId(customer.companyId);
            Models.Company company = Models.Company.getCompanyById(customer.companyId);
            foreach (Models.Item item in items)
            {
                string[] columns = { item.id.ToString(), item.name, item.quantity.ToString(), item.weight.ToString(), "%"+item.tax.ToString(),item.price.ToString() };
                var listItem = new ListViewItem(columns);
                companyItemList.Items.Add(listItem);
            }

            lblCompanyTitle.Text = company.companyName + "'s Items";
        }
    }
}
