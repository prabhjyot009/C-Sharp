using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = 5;
            int i = 1;
            int fact = 1;
            while (i <= n)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine(fact);
        }
    }
}
