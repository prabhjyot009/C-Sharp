using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class PalindromeString
    {
        static void Main(string[] args)
        {
            string str = "aba";
            string reverse = "";
            for (int i = str.Length-1; i >=0; i--)
            {
                reverse += str[i].ToString();
            }
            if (reverse == str)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }
            Console.ReadLine();
        }
    }
}
