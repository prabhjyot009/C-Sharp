using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class StringPrime
    {
        static void Main(string[] args)
        {
            string str = "12345Hello";
            for (int i = 0; i < str.Length; i++)
            {
                if (isPrime(str[i]))
                {
                    System.Console.WriteLine(str[i]);
                }
            }
        }
        static bool isPrime(char ch)
        {
            int n = ch - '0';
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
