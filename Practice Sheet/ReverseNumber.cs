using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            int rev = 0;
            int n = 1234;
            while (n > 0)
            {
                rev = (rev * 10) + n % 10;
                n = n / 10;
            }
            Console.WriteLine(rev);
        }
    }
}
