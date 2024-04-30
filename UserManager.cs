using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class UserManager
{
    private const string UsersFilePath = "../../../users.txt";

    public static void RegisterUser(string fullName, string email, string username, string password, string role = "user")
    {
        var userData = $"{fullName}|{email}|{username}|{password}|{role}";
        File.AppendAllText(UsersFilePath, userData + Environment.NewLine);
    }

    public static bool UserExists(string email, string username)
    {
        if (!File.Exists(UsersFilePath))
        {
            return false;
        }

        var users = File.ReadAllLines(UsersFilePath);
        return users.Any(user => user.Contains($"|{email}|") || user.Contains($"|{username}|"));
    }

}
