using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookProblem
{
    class UC3EditContact
    {
        public static void EditC1()
        {
            Console.WriteLine("Enter the first name of the contact you want to edit");
            string initial = Console.ReadLine();
            Datainput person = Program.People.FirstOrDefault(x => x.FirstName.ToLower() == initial.ToLower());

            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue. ");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Are you sure you want to edit this person from the address book? (Y/N)");
            Program.PrintC1(person);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Program.People.Remove(person);
                Console.WriteLine("Person removed. Press any key to continue");
                Console.ReadKey();
            }

            UC2AddContacts.AddPerson();

            Console.WriteLine("Your contact is edited succesfully");
        }
    }
}