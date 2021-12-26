using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BGMOrderAutomation.View
{
    public partial class CustomerRegisterPage : Form
    {
        public List<Models.Item> items = new List<Models.Item>();
        public CustomerRegisterPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Models.Customer customer = new Models.Customer(1, txtUsername.Text, txtPassword.Text, txtAddress.Text);
            Models.Company company = new Models.Company(1, txtCompanyName.Text ,customer, items, new List<Models.User>());
            company.addCompany();

            
            SqlCommand cmd = new SqlCommand
            {
                Connection = Models.Constant.connect,
                CommandText = "SELECT * FROM Company where company_name=@companyName"
            };
            cmd.Parameters.AddWithValue("@companyName", company.companyName);
            Models.Constant.connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int companyId =reader.Read() ?  (int)reader["id"] : 0; 
            Models.Constant.connect.Close();
            customer.companyId = companyId;
            customer.addCustomer();

            foreach (Models.Item item in items)
            {
                item.companyId = companyId;
                item.addItem();
            }
            customer.loginCustomer();
            this.Hide();
            View.CustomerHomePage customerHomePage = new View.CustomerHomePage();
            customerHomePage.ShowDialog();
            this.Close();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Models.Item item = new Models.Item(1, txtName.Text, Convert.ToInt32(maskedTextBox1.Text), float.Parse(maskedTextBox2.Text), 1, float.Parse(txtWeight.Text), Convert.ToInt32(txtTax.Text));
            items.Add(item);
            string[] columns = {  item.name,  item.quantity.ToString(), item.price.ToString("n2") + " $" };
            var listItem = new ListViewItem(columns);
            itemList.Items.Add(listItem);

            txtTax.Text = "";
            txtWeight.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            txtName.Text = "";
        }
    }
}
