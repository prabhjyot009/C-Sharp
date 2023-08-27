using System;


namespace CSharp
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int num = 0;
            int i = 0;
            int flag = 0;

            Console.WriteLine("Enter number:");
            num = int.Parse(Console.ReadLine());
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Number is not prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is prime");
        }
    }
}
