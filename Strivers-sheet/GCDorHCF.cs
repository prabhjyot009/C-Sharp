using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class GCDorHCF
    {
        static void Main(string[] args)
        {
            int i = 1;  
            int num1 = 12;
            int num2 = 15;
            int gcd = 1;
            while (i<=num1 && i<=num2)
            {
                if(num1%i==0 && num2 % i == 0)
                {
                    gcd = i;
                }
                i++;
            }
            Console.WriteLine(gcd);
            Console.ReadLine();
        }
    }
}
