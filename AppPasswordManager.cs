using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using Newtonsoft.Json;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static PixeliaPasswordManager.UserDataManager;

namespace PixeliaPasswordManager
{
    public partial class AppPasswordManager : Form
    {
        User user;
        string dataPath;
        public AppPasswordManager(User user)
        {
            InitializeComponent();
            this.user = user;
            CreateDirectories();

        }

        public AppPasswordManager()
        {
            ReLoadDataGridView();
        }

        private Data GetData()
        {

            if (File.Exists(dataPath))
            {
                try
                {
                    string json = File.ReadAllText(dataPath);
                    Data data = JsonConvert.DeserializeObject<Data>(json);
                    return data;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return new Data();
        }

        private void AppPasswordManager_Load(object sender, EventArgs e)
        {
            groupBoxPanel.Text = user.Username;
            PopulateDataGridView();
        }

        public void ReLoadDataGridView()
        {
            dataGridView.Update();
            dataGridView.Refresh();
            Data data = GetData();
            dataGridView.DataSource = data.Entries;
        }

        private void PopulateDataGridView()
        {
            Data data = GetData();
            if(data!=null)
                data.Entries.Clear();
            data = GetData();

            dataGridView.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.DataPropertyName = "Type"; // Matches the property name in the Data class
            typeColumn.HeaderText = "Type"; // Column header text
            typeColumn.Width = 200;

            DataGridViewTextBoxColumn usernameColumn = new DataGridViewTextBoxColumn();
            usernameColumn.DataPropertyName = "Username"; // Matches the property name in the Data class
            usernameColumn.HeaderText = "Username"; // Column header text
            usernameColumn.Width = 300;

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName = "Email"; // Matches the property name in the Data class
            emailColumn.HeaderText = "Email"; // Column header text
            emailColumn.Width = 400;

            DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
            passwordColumn.DataPropertyName = "Password"; // Matches the property name in the Data class
            passwordColumn.HeaderText = "Password"; // Column header text
            passwordColumn.Visible = false;

            dataGridView.Columns.Add(typeColumn);
            dataGridView.Columns.Add(usernameColumn);
            dataGridView.Columns.Add(emailColumn);
            dataGridView.Columns.Add(passwordColumn);

            if (data != null)
                dataGridView.DataSource = data.Entries;
        }



        private void CreateDirectories()
        {
            string userDirectoryPath = Path.Combine($"Data/UserData/{user.Username}");
            string dataDirectoryPath = Path.Combine($"Data/UserData/{user.Username}/data.json");
            dataPath = dataDirectoryPath;
            if (!Directory.Exists(userDirectoryPath))
            {
                Directory.CreateDirectory(userDirectoryPath);
            }
            if (!File.Exists(dataDirectoryPath))
            {
                File.Create(dataDirectoryPath);
            }
        }

        private void AppPasswordManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you want to quit?", "Confirmation", MessageBoxButtons.YesNo);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else { Application.Exit(); }


            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            checkBoxShowPassword.Checked = false;
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                if (!selectedRow.IsNewRow)
                {
                    string typeValue = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    string usernameValue = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    string emailValue = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    string passwordValue = dataGridView.SelectedRows[0].Cells[3].Value.ToString();

                    textBoxType.Clear();
                    textBoxUsername.Clear();
                    textBoxEmail.Clear();
                    textBoxPassword.Clear();

                    
                    textBoxType.Text = typeValue.ToString() + Environment.NewLine;
                    textBoxUsername.Text = usernameValue.ToString() + Environment.NewLine;
                    textBoxEmail.Text = emailValue.ToString() + Environment.NewLine;
                    textBoxPassword.Text = usernameValue.ToString();
                    UpdatePassword(passwordValue);
                }
            }
        }

        private void toolStripButtonNewEntry_Click(object sender, EventArgs e)
        {
            CreatePasswordEntry create = new CreatePasswordEntry(dataPath, this);
            create.ShowDialog();
        }

        private void UpdatePassword(string password)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.Clear();
                textBoxPassword.PasswordChar = '\0'; // Set to 0 (zero) to remove password masking
                textBoxPassword.Text = password;
            }
            else
            {
                // If the radio button is not checked, you can set a different password character
                textBoxPassword.PasswordChar = '*'; // For example, you can use '*' as a password character
                textBoxPassword.Text = password;
            }
        }

        private void checkBoxShowPassword_Click(object sender, EventArgs e)
        {
            UpdatePassword(textBoxPassword.Text);
        }

        private void toolStripButtonReload_Click(object sender, EventArgs e)
        {
            ReLoadDataGridView();
        }

        public void toolStripButtonDeleteEntry_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                textBoxType.Text = string.Empty;
                textBoxUsername.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
                textBoxPassword.Text = string.Empty;

                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                if (!selectedRow.IsNewRow)
                {
                    Data data = GetData();
                    if (data == null)
                        return;
                    // Get the values of the selected row
                    string typeValue = selectedRow.Cells[0].Value.ToString();
                    string usernameValue = selectedRow.Cells[1].Value.ToString();
                    string emailValue = selectedRow.Cells[2].Value.ToString();
                    string passwordValue = selectedRow.Cells[3].Value.ToString();

                    Entry entryToDelete = data.Entries.FirstOrDefault(entry =>
                        entry.Type.Equals(typeValue, StringComparison.OrdinalIgnoreCase) &&
                        entry.Username.Equals(usernameValue, StringComparison.OrdinalIgnoreCase) &&
                        entry.Email.Equals(emailValue, StringComparison.OrdinalIgnoreCase) &&
                        entry.Password.Equals(passwordValue, StringComparison.OrdinalIgnoreCase));


                    if (entryToDelete != null)
                    {
                        
                        //save this in a variable and then clear the data and save the variable to savedataentry
                        data.Entries.Remove(entryToDelete);

                        SaveDataEntry(data);

                        // Reload the DataGridView to reflect the changes
                        ReLoadDataGridView();
                    }
                }
            }
        }

        private void SaveDataEntry(Data userData)
        {
            string json = JsonConvert.SerializeObject(userData, Formatting.Indented);
            File.WriteAllText(dataPath, json);
        }

        private void toolStripButtonEditEntry_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                if (!selectedRow.IsNewRow)
                {
                    Data data = GetData();
                    if (data == null)
                        return;
                    // Get the values of the selected row
                    string typeValue = selectedRow.Cells[0].Value.ToString();
                    string usernameValue = selectedRow.Cells[1].Value.ToString();
                    string emailValue = selectedRow.Cells[2].Value.ToString();
                    string passwordValue = selectedRow.Cells[3].Value.ToString();

                    Entry entryToDelete = data.Entries.FirstOrDefault(entry =>
                        entry.Type.Equals(typeValue, StringComparison.OrdinalIgnoreCase) &&
                        entry.Username.Equals(usernameValue, StringComparison.OrdinalIgnoreCase) &&
                        entry.Email.Equals(emailValue, StringComparison.OrdinalIgnoreCase) &&
                        entry.Password.Equals(passwordValue, StringComparison.OrdinalIgnoreCase));


                    if (entryToDelete != null)
                    {
                        ModifyEntry modifyEntry = new ModifyEntry(entryToDelete, dataPath, this, dataGridView);
                        modifyEntry.ShowDialog();
                    }
                }
            }
        }

        private string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
            var random = new Random();
            var password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }

            return new string(password);
        }

        private void toolStripButtonGeneratePassword_Click(object sender, EventArgs e)
        {
            string randomPassword = GenerateRandomPassword(15);
            toolStripTextBoxRandomPassword.Text = randomPassword;

        }

        private void toolStripButtonCopyPassword_Click(object sender, EventArgs e)
        {
            string randomPassword = toolStripTextBoxRandomPassword.Text;

            if (!string.IsNullOrEmpty(randomPassword))
            {
                Clipboard.SetText(randomPassword); // Copy the password to the clipboard
                MessageBox.Show("Password copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCopyUsername_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUsername.Text))
            {
                Clipboard.SetText(textBoxUsername.Text); // Copy the password to the clipboard
                //MessageBox.Show("Username copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCopyEmail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEmail.Text))
            {
                Clipboard.SetText(textBoxEmail.Text); // Copy the password to the clipboard
                //MessageBox.Show("Username copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCopyPassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPassword.Text))
            {
                Clipboard.SetText(textBoxPassword.Text); // Copy the password to the clipboard
                //MessageBox.Show("Username copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
