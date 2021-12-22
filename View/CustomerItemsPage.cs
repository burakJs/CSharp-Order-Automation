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
                id: firstSelectedItem.SubItems[0].Text,
                name: firstSelectedItem.SubItems[1].Text,
                quantity: firstSelectedItem.SubItems[2].Text,
                price: firstSelectedItem.SubItems[3].Text
                ) ;
            companyItemEditPage.ShowDialog();
            this.Close();
        }
    }
}
