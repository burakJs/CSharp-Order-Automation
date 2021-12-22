using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGMOrderAutomation
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void radioCustomer_CheckedChanged(object sender, EventArgs e)
        {
            btnRegister.Text = "Customer Register";
        }

        private void radioUser_CheckedChanged(object sender, EventArgs e)
        {
            btnRegister.Text = "User Register";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (radioUser.Checked)
            {
                this.Hide();
                View.UserRegisterPage userRegisterPage = new View.UserRegisterPage();
                userRegisterPage.ShowDialog();
                this.Close();
            }
            if (radioCustomer.Checked)
            {
                this.Hide();
                View.CustomerRegisterPage customerRegisterPage  = new View.CustomerRegisterPage();
                customerRegisterPage.ShowDialog();
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Models.User user = new Models.User(1, txtUsername.Text, txtPassword.Text, "__", 0);
            if (radioUser.Checked)
            {
                if (user.loginUser())
                {
                    MessageBox.Show("Login success", user.username);
                    this.Hide();
                    View.UserHomePage userHomePage = new View.UserHomePage(user);
                    userHomePage.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
                
            }
            if (radioCustomer.Checked)
            {
                this.Hide();
                View.CustomerHomePage customerHomePage = new View.CustomerHomePage();
                customerHomePage.ShowDialog();
                this.Close();
            }
        }
    }
}
