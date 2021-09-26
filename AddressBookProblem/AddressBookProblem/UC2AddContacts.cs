using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
    class UC2AddContacts
    {
        public static void AddPerson()
        {
            Datainput person = new Datainput();

            Console.WriteLine("First Name: ");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            person.LastName = Console.ReadLine();

            Console.WriteLine("Address: ");
            person.Address = Console.ReadLine();

            Console.WriteLine("City: ");
            person.City = Console.ReadLine();

            Console.WriteLine("State: ");
            person.State = Console.ReadLine();

            Console.WriteLine("Zip: ");
            person.Zip = Console.ReadLine();

            Console.WriteLine("Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Email: ");
            person.Email = Console.ReadLine();

            Program.People.Add(person);
        }
    }
}
