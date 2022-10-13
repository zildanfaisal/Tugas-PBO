using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktorDestruktor
{
    public class Program
    {
        //Konstruktor
        public class UserKonstruktor
        {
            public string username;
            public string password;

            public UserKonstruktor(string username, string password)
            {
                this.username = username;
                this.password = password;
            }

        }
        //Destruktor
        public class UserDestruktor
        {
            public UserDestruktor()
            {
                Console.WriteLine("Instance Class Sudah Dibuat");
            }
            ~UserDestruktor()
            {
                Console.WriteLine("Instance Class Sudah di Destroy");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Konstruktor");
            UserKonstruktor petani = new UserKonstruktor("petanikode", "kopi");
            Console.WriteLine("Usernaem: " + petani.username);
            Console.WriteLine("Password: " + petani.password);
            Console.WriteLine(" ");
            Console.WriteLine("Destruktor");
            Run();
            GC.Collect();
        }
        public static void Run()
        {
            // Membuat Instance Class
            UserDestruktor user = new UserDestruktor();
        }
    }
}
