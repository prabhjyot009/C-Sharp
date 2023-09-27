using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class CheckPalindrome
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int temp = n;
            while (n > 0)
            {
                rev = (rev * 10) + n % 10;
                n = n / 10;
            }
            if (temp == rev)
            {
                Console.WriteLine("it is palindrome");
            }
            else
            {
                Console.WriteLine("it is not palindrome");
            }
        }
    }
}
