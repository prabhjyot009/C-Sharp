using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class PalindromeString
    {
        static void Main(string[] args)
        {
            string str = "heleh";
            string rev = "";
            for (int i = str.Length-1; i >=0; i--)
            {
                rev += str[i];
            }
            if (rev == str)
            {
                Console.WriteLine("It is palindrome");
            }
            else
            {
                Console.WriteLine("it is not palindrome");
            }
        }
    }
}
