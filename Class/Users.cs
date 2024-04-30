using System.IO;

namespace LoginAndRegister.Class
{
    public class Users
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; } = null;
        public string? Role { get; set; }
    }
}
