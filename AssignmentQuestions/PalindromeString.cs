using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQuestions
{
    class PalindromeString
    {
        static void Main(string[] args)
        {
            String str = "abaaba";
            int i = 0;
            int j = str.Length - 1;
            bool ispalindrome = false;
            while (i <= j)
            {
                if (str[i].Equals(str[j]))
                {
                    ispalindrome = true;
                    break;
                }
                i++;
                j--;
            }
            if (ispalindrome)
            {
                Console.WriteLine("is palindrome");
            }
            else
            {
                Console.WriteLine("is not palindrome");
            }
        }
    }
}
