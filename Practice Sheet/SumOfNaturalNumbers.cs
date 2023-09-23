using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class SumOfNaturalNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;

            while (i <= n)
            {
                sum = sum + i;                
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
