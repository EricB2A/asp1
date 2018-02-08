using System;
namespace Scrasp.Models
{
    public class User
    {
        private int id;
        private string userName;
        private string password;
        private string role;

        public User(int id, string userName = null, string password = null, string role = null)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }
        public int Id { get { return id; } }
        public string UserName { get { return userName; } set { userName = value; }  }
        public string Password { get { return password; } }
        public string Role { get { return role; } set { role = value; }  }

    }
}
