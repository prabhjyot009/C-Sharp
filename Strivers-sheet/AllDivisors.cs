using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class AllDivisors
    {
        static void Main(string[] args)
        {
            int n = 36;
            int i = 1;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    Console.Write(i+" ");
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
