using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDatatype
{
    class UC1IntegerMax
    {
        public static void MaximumInt(int a, int b, int c)
        {
            if ((a >= b) && (a >= c))
            {
                if (b >= c)
                {
                    Console.Write("  Descending order :{0} {1} {2}   ", a, b, c);

                }
                else
                {
                    Console.Write("  Descending order :{0} {1} {2}   ", a, c, b);

                }
            }
            else if ((b >= a) && (b >= c))
            {
                if (a >= c)
                {
                    Console.Write(" Descending order :{0} {1} {2}   ", b, a, c);

                }
                else
                {
                    Console.WriteLine(" Descending order :{0} {1} {2}   ", b, c, a);

                }
            }
            else if ((c >= a) && (c >= b))
            {
                if (a >= b)
                {
                    Console.WriteLine(" Descending order :{0} {1} {2}   ", c, a, b);

                }
                else
                {
                    Console.WriteLine(" Descending order :{0} {1} {2}   ", c, b, a);

                }
            }
        }
    }
}
