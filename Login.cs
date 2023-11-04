using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PixeliaPasswordManager
{
    public partial class FormLogin : Form
    {
        bool validated = false;
        public FormLogin()
        {
            InitializeComponent();
            string userDirectoryPath = Path.Combine($"Data/UserData/");

            // Check if the directory already exists (to handle duplicates)
            if (!Directory.Exists(userDirectoryPath))
            {
                Directory.CreateDirectory(userDirectoryPath);
            }
            labelFeedback.Hide();
        }

        private void ButtonNewUser_Click(object sender, EventArgs e)
        {
            CreateNewUser createUser = new CreateNewUser();
            createUser.ShowDialog();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (validated==true)
            {
                labelFeedback.Hide();
                buttonNewUser.Show();
                buttonForgotUser.Show();
                validated = false;
                buttonLogin.Text = "Login";
                return;
            }

            string username = textBoxUsername.Text;
            string enteredPassword = textBoxPassword.Text; 

            User user = UserDataManager.GetUserByUsername(username);
            if (username == "admin" && UserAuthentication.AuthenticateUser(enteredPassword, user))
            {
                MessageBox.Show("Admin");
                AdminManager adminManager = new AdminManager();
                adminManager.Show();
                this.Hide();
            }
            else if (user != null && UserAuthentication.AuthenticateUser(enteredPassword, user))
            {
                AppPasswordManager appPasswordManager = new AppPasswordManager(user);
                appPasswordManager.Show();
                this.Hide();
            }
            else
            {
                // Authentication failed; display an error message
                labelFeedback.Show();
                labelFeedback.Text = "Login failed.\nPlease check your credentials.";
                buttonNewUser.Hide();
                buttonForgotUser.Hide();
                validated = true;
                buttonLogin.Text = "OK";
            }

        }

    }
}
