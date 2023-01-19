using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{
    class Program
    {

        static int findMax(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c || a == c)
                    return a;
            }

            if (b > c)
            {
                if (b > a || b == a)
                    return b;
            }
            return c;
        }

        //The most efficient way to find the maximum number

        static int findMaxNo2(int a, int b, int c)
        {
            int max = a;

            if(b > max)
                max = b;

            if (c > max)
                max = c;
            return max;
        }

        static void Main(string[] args)
        {

            Console.Title = "finMaximumNumber";

            //find Max Number for first Method

            Console.WriteLine("List the Biggest Number 1");
            Console.WriteLine(findMax(25, 56, 03));
            Console.WriteLine(findMax(36, 25, 17));
            Console.WriteLine(findMax(60, 01, 03));
            Console.WriteLine(findMax(60, 20,103));
            Console.WriteLine();
            Console.WriteLine("List the Biggest Number 2");
            Console.WriteLine(findMaxNo2(65, 56, 03));
            Console.WriteLine(findMaxNo2(36, 25, 17));
            Console.WriteLine(findMaxNo2(60, 01, 03));
            Console.WriteLine(findMaxNo2(03, 09, 03));
            Console.ReadLine();

        }
    }
}
