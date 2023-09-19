using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter prime:");
            int n = Int32.Parse(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i <=n/2; i++)
            {
                if (n%i==0)
                {
                    isprime = false;
                    break;
                }
            }
            if (n!=1 && isprime)
            {
                Console.WriteLine("it is prime");
            }
            else
            {
                Console.WriteLine("it is not prime");
            }

        }
    }
}
