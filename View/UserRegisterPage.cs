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
    public partial class UserRegisterPage : Form
    {
        public UserRegisterPage()
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
            Models.User user = new Models.User(1, txtUsername.Text, txtPassword.Text, "Mahalle cadde", 0);
            user.createUser();
        }
    }
}
