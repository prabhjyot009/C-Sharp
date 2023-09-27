using System;

namespace CSharp
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
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
