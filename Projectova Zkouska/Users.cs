using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectova_Zkouska
{
    internal class Users
    {
        public string Name {get; private set;}
        public string LastName { get; private set;}
        public int Age { get; private set;}
        public int PhoneNumber { get; private set;}

        public Users(string name, string lastName, int age, int phoneNumber)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return String.Format("Name: {0} \n" +
                "LastName: {1}\n" +
                "Age: {2}\n " +
                "PhoneNumber: {3}", Name, LastName, Age, PhoneNumber);
        }
    }
}
