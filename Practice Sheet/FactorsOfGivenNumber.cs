using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class FactorsOfGivenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Int32.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    Console.Write(i+" ");
                }
                i++;
            }
        }
    }
}
