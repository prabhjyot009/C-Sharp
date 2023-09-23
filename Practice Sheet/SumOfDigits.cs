using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 123;
            int sum = 0;
            while (n > 0)
            {
                sum = sum + (n % 10);
                n = n / 10;
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
