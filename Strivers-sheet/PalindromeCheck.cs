using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class PalindromeCheck
    {
        static void Main(string[] args)
        {
            int num = 121;
            int rev = 0;
            int temp = num;
            while (num != 0)
            {
                rev = (rev * 10) + num % 10;
                num = num / 10;
            }
            if (temp == rev)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
