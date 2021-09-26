using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookProblem
{
    class Program
    {
        public static List<Datainput> People = new List<Datainput>();

        static void Main(string[] args)
        {
            UC4DeleteContacts remove = new UC4DeleteContacts();
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("-----------------------------WELCOME TO ADDRESS BOOK---------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------");

                Console.WriteLine("Use the given commands to Create Contact in AddressBook: 'add', 'remove', 'edit' 'list', 'exit'");
                Console.WriteLine("Please enter a command :");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                        UC2AddContacts.AddPerson();
                        break;
                    case "remove":
                        UC4DeleteContacts.RemoveC1();
                        break;
                    case "edit":
                        UC3EditContact.EditC1();
                        break;
                    case "list":
                        ListC1();
                        break;
                }
            }

        }





        public static void ListC1()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book: \n");
            foreach (var C1 in People)
            {
                PrintC1(C1);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        public static void PrintC1(Datainput C1)
        {
            Console.WriteLine("First Name: " + C1.FirstName);
            Console.WriteLine("Last Name: " + C1.LastName);
            Console.WriteLine("Address: " + C1.Address);
            Console.WriteLine("City: " + C1.City);
            Console.WriteLine("State: " + C1.State);
            Console.WriteLine("Zip: " + C1.Zip);
            Console.WriteLine("Phone Number: " + C1.PhoneNumber);
            Console.WriteLine("Email: " + C1.Email);
            Console.WriteLine("---------------------------------------");

        }
    }

    public class Datainput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }

}