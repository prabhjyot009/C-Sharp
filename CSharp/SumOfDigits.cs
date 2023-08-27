using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class SumOfDigits
    {
        int num = 0;
        int sum = 0;
        int rem = 0;

        public void CheckSumOfDigits()
        {
            Console.WriteLine("Enter number:");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine("Sum of digits is: " + sum);
        }
    }
}
