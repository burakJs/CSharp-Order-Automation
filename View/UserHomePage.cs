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
        private Models.User user;
        private Models.Item item;
        public UserHomePage()
        {
            InitializeComponent();
        }
        private void btnBasket_Click(object sender, EventArgs e)
        {
            Models.Order order = Models.Order.getUserOrder(user.memberId);
            order.addOrder(order.orderId);
            this.Hide();
            View.BasketDetailPage basketDetailPage = new View.BasketDetailPage();
            basketDetailPage.ShowDialog();
            this.Close();
        }

        private void UserHomePage_Load(object sender, EventArgs e)
        {
            user = Models.User.getLoginedUser();
            lblUsername.Text = user.username;
            Models.Item item = new Models.Item();
            foreach(Models.Item i in item.getAll()){
                string[] columns = { i.id.ToString(), i.name, i.price.ToString(), "%" + i.tax.ToString() };
                var listItem = new ListViewItem(columns);
                itemList.Items.Add(listItem);
            }
        }

        private void itemList_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = itemList.SelectedItems[0];
            //MessageBox.Show(firstSelectedItem.SubItems[1].Text);
            txtItemID.Text = firstSelectedItem.SubItems[0].Text;
            item = new Models.Item(1, firstSelectedItem.SubItems[1].Text, 1, float.Parse(firstSelectedItem.SubItems[2].Text), 1, 0, 0);
            lblTotalPrice.Text = item.getPriceForQuantity(Convert.ToInt32(comboItemQuantity.SelectedItem)).ToString() + " $";

        }

        private void comboItemQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(item != null)
            {
                lblTotalPrice.Text = item.getPriceForQuantity(Convert.ToInt32(comboItemQuantity.SelectedItem)).ToString() + " $";
            }
            else
            {
                MessageBox.Show("Select any items please");
            }
            
        }

        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            Models.Item item = new Models.Item();
            item = item.getItemByID(Convert.ToInt32(txtItemID.Text));
            Models.Order order = Models.Order.getUserOrder(user.memberId);
            Models.OrderDetail orderDetail = new Models.OrderDetail(1, Convert.ToInt32(comboItemQuantity.SelectedItem), item, item.tax,order.orderId);
            orderDetail.createOrderDetail(1);
            txtItemID.Text = "";
            comboItemQuantity.Text = "";
            lblTotalPrice.Text = "0 $";
        }
    }
}
