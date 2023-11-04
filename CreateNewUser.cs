using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixeliaPasswordManager
{
    public partial class CreateNewUser : Form
    {
        public CreateNewUser()
        {
            InitializeComponent();
            labelNoMatch.Hide();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == textBoxPassword2.Text)
            {
                CreateUser();
            }
            else
            {
                labelNoMatch.Show();
            }
        }

        private void CreateUser()
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string hashedPassword = UserAuthentication.HashPassword(password);

            User newUser = new User();
            newUser.Username = username;
            newUser.MasterPasswordHash = hashedPassword;
            try
            {
                UserDataManager.SaveUser(newUser);
                MessageBox.Show("User created sucesfuly!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }

    }
}
