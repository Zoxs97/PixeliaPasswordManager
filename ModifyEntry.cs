using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PixeliaPasswordManager
{
    public partial class ModifyEntry : Form
    {
        Entry entry;
        string dataPath;
        AppPasswordManager passwordManager;
        DataGridView dataGrid;
        public ModifyEntry(Entry entry, string dataPath, AppPasswordManager app, DataGridView dataGrid)
        {
            InitializeComponent();
            this.entry = entry;
            this.dataPath = dataPath;
            this.passwordManager = app;
            textBoxUsername.ForeColor = Color.Gray;
            textBoxEmail.ForeColor = Color.Gray;
            textBoxPassword.ForeColor = Color.Gray;
            textBoxUsername.Text = entry.Username;
            textBoxPassword.Text = entry.Password;
            textBoxEmail.Text = entry.Email;
            this.dataGrid = dataGrid;
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

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == entry.Username.ToString())
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black; // Change the text color back to black
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                textBoxUsername.Text = entry.Username.ToString();
                textBoxUsername.ForeColor = Color.Gray; // Change the text color to gray
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == entry.Email.ToString())
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black; // Change the text color back to black
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                textBoxEmail.Text = entry.Email.ToString();
                textBoxEmail.ForeColor = Color.Gray; // Change the text color to gray
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == entry.Password.ToString())
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black; // Change the text color back to black
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.Text = entry.Password.ToString();
                textBoxPassword.ForeColor = Color.Gray; // Change the text color to gray
            }
        }
        private void SaveDataEntry(Data userData)
        {
            string json = JsonConvert.SerializeObject(userData, Formatting.Indented);
            File.WriteAllText(dataPath, json);
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            if (textBoxPassword.Text != string.Empty && textBoxUsername.Text != string.Empty && comboBoxEntryType.Text != string.Empty)
            {
                Data data = GetData();
                if (data == null)
                    return;

                if (dataGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGrid.SelectedRows[0];

                    if (!selectedRow.IsNewRow)
                    {
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
                            passwordManager.ReLoadDataGridView();
                        }
                    }
                }

                // Create a new entry with updated values
                Entry newEntry = new Entry
                {
                    Type = comboBoxEntryType.Text,
                    Username = textBoxUsername.Text,
                    Password = textBoxPassword.Text,
                    Email = textBoxEmail.Text
                };

                // Add the new entry to the data
                data.Entries.Add(newEntry);

                // Save the updated data
                SaveDataEntry(data);

                // Reset the input fields
                comboBoxEntryType.Text = string.Empty;
                textBoxPassword.Text = string.Empty;
                textBoxUsername.Text = string.Empty;
                textBoxEmail.Text = string.Empty;

                MessageBox.Show("Password entry saved!");

                // Close the form or take any other necessary actions
                Close();

                // Reload the DataGridView to reflect the changes
                passwordManager.ReLoadDataGridView();


            }
        }



        private void comboBoxEntryType_Enter(object sender, EventArgs e)
        {
            comboBoxEntryType.Items.Clear();

            Data data = GetData();
            if (data == null)
                return;
            foreach (var type in data.Types)
            {
                comboBoxEntryType.Items.Add(type);
            }

            if (comboBoxEntryType.Items.Count == 0)
            {
                return;
            }
        }
    }
}
