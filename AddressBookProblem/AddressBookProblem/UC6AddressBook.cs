using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
    class UC6AddressBook
    {
        public static List<Person2> People2 = new List<Person2>();

        public static void AddAddress()
        {

            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("*********Welcome to New Address Book***********");
                Console.WriteLine("***********************************************");
                Console.WriteLine("Use the given commands to Create Contact in AddressBook: 'add', 'remove', 'edit', 'addmultiple', 'AddressBook2' 'list', 'exit'.");
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
                        UC3EditContacts.EditC1();
                        break;
                    case "addmultiple":
                        UC5AddMultipleContacts.addMultiple();
                        break;
                    case "list":
                        UC1CreateContact.ListPeople();
                        break;
                }
            }

        }

        public static void AddPerson2()
        {
            Person2 person2 = new Person2();

            Console.WriteLine("First Name: ");
            person2.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            person2.LastName = Console.ReadLine();

            Console.WriteLine("Address: ");
            person2.Address = Console.ReadLine();

            Console.WriteLine("City: ");
            person2.City = Console.ReadLine();

            Console.WriteLine("State: ");
            person2.State = Console.ReadLine();

            Console.WriteLine("Zip: ");
            person2.Zip = Console.ReadLine();

            Console.WriteLine("Phone Number: ");
            person2.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Email: ");
            person2.Email = Console.ReadLine();

            UC6AddressBook.People2.Add(person2);
        }

        public static void PrintPerson(Person2 person2)
        {
            Console.WriteLine("First Name: " + person2.FirstName);
            Console.WriteLine("Last Name: " + person2.LastName);
            Console.WriteLine("Address: " + person2.Address);
            Console.WriteLine("City: " + person2.City);
            Console.WriteLine("State: " + person2.State);
            Console.WriteLine("Zip: " + person2.Zip);
            Console.WriteLine("Phone Number: " + person2.PhoneNumber);
            Console.WriteLine("Email: " + person2.Email);
            Console.WriteLine("---------------------------------------");

        }
    }



    public class Person2
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
