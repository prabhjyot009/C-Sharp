using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class NaturalNumbersRecursion
    {
        static void printnTimes(int n)
        {
            if (n == 1)
            {
                Console.Write("1");
                return ;
            }
            printnTimes(n - 1);
            Console.Write(" "+n+"");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n times");
            int n = Convert.ToInt32(Console.ReadLine());
            printnTimes(n);
        }
    }
}
