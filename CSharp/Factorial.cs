using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Int32.Parse(Console.ReadLine());
            int fact = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    fact = fact * i;
            //}
            if (n<0)
            {
                Console.WriteLine("Please provide value greater than zero");
            }
            else
            {
                for (int i = n; i >= 1; i--)
                {
                    fact *= fact;
                }
                Console.WriteLine("{0}! is {1}", n, fact);
            }
        }
    }
}
