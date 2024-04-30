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

namespace WinFormsApp2.Page
{
    public partial class SuperAdmin : Form
    {
        public SuperAdmin(int ID)

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

        private void SuperAdmin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = "superadmin";
            SaveAllUsersToFile(username);
            System.Diagnostics.Process.Start($"notepad.exe", @$"../../../Files/{username}.txt");
        }

        public void SaveAllUsersToFile(string username)
        {
            var users = LoadUsers();

            string filePath = $"../../../Files/{username}.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var user in users)
                {
                    writer.WriteLine($"Username: {user.UserName}, Name: {user.FullName}, Email: {user.Email}");
                }
            }
        }
        public List<Users> LoadUsers()
        {
            string json = File.ReadAllText("../../../DataBase/Users.json");
            return JsonConvert.DeserializeObject<List<Users>>(json);
        }
    }
}
