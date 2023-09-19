using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class PrintNameNtimes
    {
        static void printnTimes(int i,int n)
        {
            if (i > n)
            {
                return;
            }
            Console.WriteLine("Singh");
            printnTimes(i + 1, n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n times");
            int n=Convert.ToInt32(Console.ReadLine());
            printnTimes(1,n);
        }
    }
}
