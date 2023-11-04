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

namespace PixeliaPasswordManager
{
    public partial class CreatePasswordEntry : Form
    {
        private string dataPath;
        AppPasswordManager passwordManager;
        public CreatePasswordEntry(string dataPath, AppPasswordManager app)
        {
            InitializeComponent();
            this.dataPath = dataPath;
            passwordManager = app;
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

        private void SaveDataEntry(Data userData)
        {
            Data existingData = GetData();
            existingData.Entries.AddRange(userData.Entries);
            string json = JsonConvert.SerializeObject(existingData, Formatting.Indented);
            File.WriteAllText(dataPath, json);
            Console.WriteLine("Saving data : " + json);
        }

        private void SaveDataType(Data userData)
        {

            Data existingData = GetData();
            if (existingData == null)
                existingData = new Data();
            existingData.Types.AddRange(userData.Types);
            string json = JsonConvert.SerializeObject(existingData, Formatting.Indented);
            File.WriteAllText(dataPath, json);
            Console.WriteLine("Saving data : " + json);
        }

        private void buttonCreateType_Click(object sender, EventArgs e)
        {
            if (textBoxCreateType.Text != string.Empty)
            {
                Data data = new Data();
                string type = textBoxCreateType.Text;
                data.Types.Add(type);
                SaveDataType(data);
                textBoxCreateType.Text = string.Empty;
            }
        }

        private void buttonCreateEntry_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != string.Empty && textBoxUsername.Text != string.Empty && comboBoxEntryType.Text != string.Empty)
            {
                Data data = new Data();
                Entry entry = new Entry();
                entry.Type = comboBoxEntryType.Text;
                entry.Username = textBoxUsername.Text;
                entry.Password = textBoxPassword.Text;
                entry.Email = textBoxEmail.Text;
                data.Entries.Add(entry);
                SaveDataEntry(data);
                comboBoxEntryType.Text = string.Empty;
                textBoxPassword.Text = string.Empty;
                textBoxUsername.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
                MessageBox.Show("Password entry saved!");
                Close();
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
