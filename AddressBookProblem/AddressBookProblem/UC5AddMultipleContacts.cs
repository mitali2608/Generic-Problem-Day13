using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
        class UC5AddMultipleContacts
        {
            public static void addMultiple()
            {
                int num;
                Console.WriteLine("Enter the number of contacts you want to create-");
                num = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                while (i < num)
                {
                UC2AddContacts.AddPerson();
                    Console.WriteLine("---------------------------");
                    i++;
                }
            }
        }
    }

