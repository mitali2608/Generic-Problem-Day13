using System;
using GenericDatatype;
using System.Collections.Generic;

namespace GenericDataType
{
    class Program
    {
        public T Maximum<T>(T x, T y, T z) where T : IComparable
        {

            T max = x;

            if (y.CompareTo(max) > 0)
                max = y;

            if (z.CompareTo(max) > 0)
                max = z;

            Console.WriteLine("Printing value inside Generic method Maximum  value :  " + max);

        }


        public void Main(string[] args)
        {


            Console.WriteLine("  Generic Program Using  method UC1:");

            Console.WriteLine("  Find largest among three integers in order:");

            Console.WriteLine("Numbers in decrease order :");
            UC1IntegerMax.MaximumInt(33, 56, 26);


            Console.WriteLine(" -------------------UC2-------------------- ");
            Console.WriteLine("  Find largest of three fractions in order:");

            Console.WriteLine("Numbers in decrease order :");
            UC2DoubleMax.MaximumDouble(3.6, 2.3, 0.9);

            Console.WriteLine("-------------------UC3---------------------");

            Console.WriteLine("  Find largest of three string in order:");

            Console.WriteLine("Strings in decrease order :");
            UC3StringMax.MaxStrings("Green", "Blue", "Pink");


            Console.WriteLine("--------Refactor 1--------");
            Console.WriteLine("  Using generic method:");

            Console.WriteLine("  Numbers to compare:");

            Console.WriteLine("Maximum of  :26, 85, 13 ");
            var a = Maximum(26, 85, 13);
            Console.WriteLine("Maximum value :  " + a);
            Console.WriteLine("                           ");
            Console.WriteLine(" fraction number to compare:");
            Console.WriteLine("                           ");
            Console.WriteLine("Maximum of  :3.1 ,6.2 , 8.4");
            var b = Maximum(3.1, 6.2, 8.4);
            Console.WriteLine("Maximum value :  " + b);
            Console.WriteLine("                          ");
            Console.WriteLine(" words or alphabet to compare:");
            Console.WriteLine("                          ");
            Console.WriteLine("Maximum of  : M, P, B");
            var c = Maximum("M", "P", "B");
            Console.WriteLine("Maximum value :  " + c);

            Console.WriteLine("Maximum of  : Cat, Money , Peace");
            var d = Maximum("Cat", "Money", "Peace");
            Console.WriteLine("Maximum value :  " + d);

            Console.WriteLine("-------------UC4------------------");
            //Taking more than 3 numbers-UC4 and Refactor2 using generic class to find maximum
            int[] intArray = { 112, 344, 432, 555, 678 };
            UC5GenericMax<int> generic = new UC5GenericMax<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            UC5GenericMax<double> genericDouble = new UC5GenericMax<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "Banana", "Apple", "Orange", "Lemon", "Coconut" };
            UC5GenericMax<string> genericString = new UC5GenericMax<string>(stringArray);
            genericString.PrintMaxValue();
            Console.WriteLine("                           ");
            Console.WriteLine("------------UC5-------------------");
            generic.PrintMaxValue();
            genericDouble.PrintMaxValue();
            genericString.PrintMaxValue();
        }

    }
}
