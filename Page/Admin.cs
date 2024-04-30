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
    public partial class Admin : Form
    {
        public Admin(int ID)
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

        private void Admin_Load(object sender, EventArgs e)
        {

        }
 
        public List<Users> LoadUsers()
        {
            string json = File.ReadAllText("../../../DataBase/Users.json");
            return JsonConvert.DeserializeObject<List<Users>>(json);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = "admin";
            SaveOnlyUsersToFile(username);
            System.Diagnostics.Process.Start($"notepad.exe", @$"../../../Files/{username}.txt");
        }
        public void SaveOnlyUsersToFile(string username)
        {
            var users = LoadUsers().Where(u => u.Role == "user").ToList();
            string filePath = $"Files/{username}_users.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var user in users)
                {
                    writer.WriteLine($"Username: {user.UserName}, Name: {user.FullName}, Email: {user.Email}");
                }
            }
        }


    }
}
