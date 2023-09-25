using System;


namespace CSharp
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int flag = 0;

            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num / 2; i++)
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
