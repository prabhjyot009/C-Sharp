using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class NPrime
    {
        static bool isPrime(int n)
        {
            if(n==1 || n == 0)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = Int32.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i+" ");
                }
            }
            Console.ReadLine();
        }
    }
}
