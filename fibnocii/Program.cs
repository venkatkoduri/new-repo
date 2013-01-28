using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fibnocii
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt16(Console.ReadLine());
            fibnocii(n);
        }
        static int fibnocii(int n)
        {
            int x = 1;
            int y = 1;
            int add;
            int i;
            Console.WriteLine("fibnocci numbers are");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(x);
                add = x + y;
                x = y;
                y = add;
            }
            return 0;
        }

    }
}
