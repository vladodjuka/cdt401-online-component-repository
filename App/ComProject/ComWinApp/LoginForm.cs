using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerUnit;

namespace ComWinApp
{
    public partial class LoginForm : Form
    {
        UserDb users = new UserDb();
      
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(users.doesUserExist(usernameField.Text, passwordField.Text))
            {
                errorLabel.Hide();
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                errorLabel.Show();
                errorLabel.Text = "Wrongly typed username / password";
            }
        }
    }
}
