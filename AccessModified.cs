using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModified
{
    //Modified Public
    class PublicPerson
    {
        public string name = "Muhammad";
    }
    //Modified Protected
    class ProtectedPerson
    {
        protected string name = "Zildan";
    }
    class Program : ProtectedPerson
    {
        //Modified Private
        class PrivatePerson
        {
            private string name = "Faisal";
            static void Main(String[] args)
            {
                Console.WriteLine("Access Modified Public");
                PublicPerson person = new PublicPerson();
                Console.WriteLine(person.name);
                Console.WriteLine("");
                Console.WriteLine("Access Modified Protected");
                Program program = new Program();
                Console.WriteLine(program.name);
                Console.WriteLine("");
                Console.WriteLine("Access Modified Private");
                PrivatePerson privatePerson = new PrivatePerson();
                Console.WriteLine(privatePerson.name);
            }
        }
    }
}
