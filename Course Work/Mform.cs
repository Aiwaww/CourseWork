using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Windows.Forms;

namespace Course_Work
{   
    public partial class Mform : Form
    {
        private Client? selectedClient;

        public Mform()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            users.Items.Clear();

            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1111;Database=shop";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("SELECT * FROM clients", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int clientId = reader.GetInt32(0);
                            string clientName = reader.GetString(1);

                            users.Items.Add(new Client(clientId, clientName));
                        }
                    }
                }
            }
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if (this.selectedClient == null)
            {
                return;
            }

            this.Hide();
            new UserForm(this.selectedClient).ShowDialog();
            this.Show();
        }

        private void users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (users.SelectedItem == null)
            {
                return;
            }

            this.selectedClient = (Client)users.SelectedItem;
        }
        private void visible_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }

        private void TogglePasswordVisibility()
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "Admin" && password == "12345")
            {
                
                this.Hide();
                new AdminForm().ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Неправильний логін чи пароль!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBoxColor(textBox1, "Username");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBoxColor(textBox2, "Password");
        }

        private void UpdateTextBoxColor(TextBox textBox, string defaultText)
        {
            textBox.ForeColor = textBox.Text == defaultText ? Color.Black : SystemColors.ControlText;
        }
    }
}
    


