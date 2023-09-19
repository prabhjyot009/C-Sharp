using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            int num = 153;
            int sum = 0;
            int temp = num;
            while (num != 0)
            {
                sum += (num % 10) * (num % 10) * (num % 10);
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("It is armstrong"); 
            }
            else
            {
                Console.WriteLine("Not armstrong");
            }
            Console.ReadLine();
        }
    }
}
