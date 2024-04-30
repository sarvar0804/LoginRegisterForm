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
using WinFormsApp2.Page;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp2
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void loginLabel1_Click(object sender, EventArgs e)
        {

        }
        private void loginLabel2_Click(object sender, EventArgs e)
        {

        }

        private void logTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void loginLabel3_Click(object sender, EventArgs e)
        {

        }

        private void logTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (logTextBox2.Text.Length < 4)
            {
                loginLabel3.ForeColor = Color.Red;
                loginLabel3.Text = "Kamida 4 belgi kiriting!";
            }
            else
            {
                loginLabel3.ForeColor = SystemColors.ControlText;
                loginLabel3.Text = "Password";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = logTextBox1.Text;
            string password = logTextBox2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
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

            var user = users.FirstOrDefault(u => u.UserName == username && u.Password == password);

            if (user == null)
            {
                MessageBox.Show("Foydalanuvchi nomi yoki parol noto'g'ri.");
                return;
            }

            // Foydalanuvchining role'iga qarab mos formasiga o'tish
            switch (user.Role)
            {
                case "SuperAdmin":
                    SuperAdmin superAdminForm = new SuperAdmin(user.Id);
                    superAdminForm.Show();
                    break;
                case "Admin":
                    Admin adminForm = new Admin(user.Id);
                    adminForm.Show();
                    break;
                case "User":

                    User userForm = new User(user.Id);
                    userForm.Show();
                    break;
                default:
                    MessageBox.Show("Foydalanuvchining roli noto'g'ri.");
                    break;
            }

            this.Hide();

        }
        private void loginLabel4_Click(object sender, EventArgs e)
        {

        }

        private void loginLinkedLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.StartPosition = FormStartPosition.WindowsDefaultLocation;
            register.Show();
            this.Hide();
        } 
    }
}