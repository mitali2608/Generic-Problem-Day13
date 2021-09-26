using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Address_Book
{
    class UC4DeleteContacts
    {
        public static void RemoveC1()
        {
            Console.WriteLine("Enter the first name you want to remove.");
            string firstName = Console.ReadLine();
            Datainput C1 = Program.People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());

            if (C1 == null)
            {
                Console.WriteLine("That C1 could not be found. Press any key to continue. ");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Are you sure you want to remove C1 from this Address Book? (Y/N)");
            Program.PrintC1(C1);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Program.People.Remove(C1);
                Console.WriteLine("C1 removed. Press any key to continue");
                Console.ReadKey();
            }
        }
    }
}