using LoginAndRegister.Class;
using Newtonsoft.Json;
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

namespace WinFormsApp2.Page
{
    public partial class User : Form
    {
        public User(int ID)
        {
            InitializeComponent();

            string path = @"../../../DataBase/Users.json";

            List<Users> users = new List<Users>();

            if (File.Exists(path))
            {
                var existingUsersJson = File.ReadAllText(path);
                users = System.Text.Json.JsonSerializer.Deserialize<List<Users>>(existingUsersJson);
            }

            var user = users.FirstOrDefault(u => u.Id == ID);

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = "user";
            SaveCurrentUserToFile(username);
            System.Diagnostics.Process.Start("notepad.exe", "../../../Files/yourfilename.txt");
        }

        public void SaveCurrentUserToFile(User Username)
        {
            string filePath = $"../../../Files/{Username.Name}_info.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Name: {Username.Name}");
                writer.WriteLine($"Email: {Username.}");
                writer.WriteLine($"Username: {Username.UserName}");
                writer.WriteLine($"Password: {Username.Password}");
            }
        }
        public List<Users> LoadUsers()
        {
            string json = File.ReadAllText("../../../DataBase/Users.json");
            return JsonConvert.DeserializeObject<List<Users>>(json);
        }
    }
}
