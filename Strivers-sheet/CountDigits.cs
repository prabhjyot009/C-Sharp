using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class CountDigits
    {
        static void Main(string[] args)
        {
            int num = 123;
            int count = 0;
            while (num!=0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
