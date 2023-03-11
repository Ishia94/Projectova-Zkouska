using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectova_Zkouska
{
    internal class Database
    {
        private List<Users> user = new List<Users>();
        public Database() 
        {
            user=new List<Users>();
        }

        public void Menu()
        {
            Console.WriteLine("Options: ");
            Console.WriteLine("1- Add user");
            Console.WriteLine("2- Find User");
            Console.WriteLine("3- Show users");
            Console.WriteLine("4- Exit");
        }

        public void AddUser()
        {
            Console.WriteLine("Please Add your name: ");
            string name;
            while (string.IsNullOrWhiteSpace(name = Console.ReadLine()))
            {
                Console.WriteLine("Error. Please try again.");
            }
            Console.WriteLine("Please Add your LastName: ");
            string lastName;
            while (string.IsNullOrWhiteSpace(lastName = Console.ReadLine()))
            {
                Console.WriteLine("Error. Please try again. ");
            }
            Console.WriteLine("Please Add your Birthday.  ");
            int age; 
                while (int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Error. Please try again. ");
            }
            Console.WriteLine("Your Phone Number: ");
            int phoneNumber;
            while (int.TryParse(Console.ReadLine(), out phoneNumber))
            {
                Console.WriteLine("Error. Please Try again. ");
            }
            user.Add(new Users(name, lastName, age, phoneNumber));
        }
        public void FindUser()
        {
            Console.WriteLine("Name: ");
            var findName = Console.ReadLine();
            Console.WriteLine("LastName: ");
            var findLast = Console.ReadLine();

            foreach (var a in user)
            {
                if ((a.Name == findName && a.LastName == findLast))
                {
                    Console.WriteLine("");
                    Console.WriteLine(a);
                    return;
                }
            }
            Console.WriteLine("Not Exist");

        }
        public void ShowUsers()
        {
            int countAll = 0;
            foreach (var s in user)
            {
                countAll++;
            }
            if (countAll < 0)
                Console.WriteLine("Users.");
            else if (countAll == 0)
                Console.WriteLine("No one is registred:");
            foreach ( var s in user)
            {
                Console.WriteLine(s);
            }
        }
    }
}
