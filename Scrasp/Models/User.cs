using System;
namespace Scrasp.Models
{
    public class User
    {
        private string userName;
        private string password;
        private string role;

        public User(string userName, string password, string role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }

        public string UserName { get { return userName; } }
        public string Password { get { return password; } }
        public string Role { get { return role; } }
    }
}
