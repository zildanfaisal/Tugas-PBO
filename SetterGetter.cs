using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetterGetter
{
    class User
    {
        static void Main(String[] args)
        {
            user z = new user();
            z.Username = "zildanfaisal";
            z.Password = "zildan123";

            Console.WriteLine("Username: " + z.Username);
            Console.WriteLine("Password: " + z.Password);
        }
    }
    public class user
    {
        string username;
        string password;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
