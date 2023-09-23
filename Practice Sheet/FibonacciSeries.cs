using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int fib1 = 0;
            int fib2 = 1;
            int n = 5;
            int i = 2;
            Console.Write(fib1+" "+fib2);
            while (i <= n)
            {
                int fib3 = 0;
                fib3 = fib1 + fib2;
                Console.Write(" "+fib3);
                fib1 = fib2;
                fib2 = fib3;
                i++;
            }
            Console.ReadLine();
        }

    }
}
