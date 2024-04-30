using LoginAndRegister.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            // Logic for when the form loads
        }

        private void signupLabel1_Click(object sender, EventArgs e)
        {
            // Logic for signupLabel1
        }

        private void signupLabel2_Click(object sender, EventArgs e)
        {
            // Logic for signupLabel2
        }
        private void regTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!regTextBox1.Text.Contains(" "))
            {
                signupLabel2.ForeColor = Color.Red;
                signupLabel2.Text = "Name xato!";
            }
            else
            {
                signupLabel2.ForeColor = SystemColors.ControlText;
                signupLabel2.Text = "Full Name";
            }
        }

        private void signupLabel3_Click(object sender, EventArgs e)
        {
            // Logic for signupLabel3
        }
        private void regTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!regTextBox2.Text.Contains("@") || !regTextBox2.Text.Contains("."))
            {
                signupLabel3.ForeColor = Color.Red;
                signupLabel3.Text = "Email formati noto'g'ri!";
            }
            else
            {
                signupLabel3.ForeColor = SystemColors.ControlText;
                signupLabel3.Text = "Email or username";
            }
        }

        private void signupLabel4_Click(object sender, EventArgs e)
        {
            // Logic for signupLabel4
        }
        private void regTextBox3_TextChanged(object sender, EventArgs e)
        {
            // Logic for regTextBox3
        }

        private void signupLabel5_Click(object sender, EventArgs e)
        {
            // Logic for signupLabel5
        }
        private void regTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (regTextBox4.Text.Length < 4)
            {
                signupLabel5.ForeColor = Color.Red;
                signupLabel5.Text = "Kamida 4 belgi kiriting!";
            }
            else
            {
                signupLabel5.ForeColor = SystemColors.ControlText;
                signupLabel5.Text = "Password";
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string fullName = regTextBox1.Text;
            string email = regTextBox2.Text;
            string username = regTextBox3.Text;
            string password = regTextBox4.Text;

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiritish kerak.");
                return;
            }

            string path = @"../../../DataBase/Users.json";

            List<Users> users = new List<Users>();

            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                users = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(existingUsersJson);
            }

            if (users.Any(u => u.UserName == username))
            {
                MessageBox.Show("Foydalanuvchi ro'yxatdan o'tgan");
                return;
            }

            int nextId = users.Count > 0 ? users.Max(u => u.Id) + 1 : 1;

            Users user = new Users
            {
                Id = nextId,
                FullName = fullName,
                Password = password,
                UserName = username,
                Email = email,
                Role = "User"
            };

            users.Add(user);

            var options = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = System.Text.Json.JsonSerializer.Serialize(users, options);

            File.WriteAllText(path, json);
            MessageBox.Show("Siz muvaffaqiyatli ro'yxatdan o'tdingiz");
            // Login formaga o'tish
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void signupLabel6_Click(object sender, EventArgs e)
        {
            // Logic for signupLabel6
        }

        private void signupLinkedLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.StartPosition = FormStartPosition.WindowsDefaultLocation;
            login.Show();
            this.Hide();
        }
    }
}