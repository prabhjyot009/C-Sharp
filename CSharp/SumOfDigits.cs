using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;
                Console.WriteLine("Enter number:");
                num = int.Parse(Console.ReadLine());
                while (num > 0)
                {
                    sum = sum + (num%10);
                    num = num / 10;
                }
                Console.WriteLine("Sum of digits is: " + sum);
        }

    }
}
