using System;

namespace CSharp
{
    class PalindromeString
    {
        static void Main(string[] args)
        {
            string str = "aba";
            string reverse1 = "";
            string reverse = " ";
            string rev2 = "";        
          /*  for (int i = str.Length-1; i >=0; i--)
            {
                reverse += str[i];
            }
            if (reverse == str)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }*/

            //for(int i = 0; i < str.Length; i++)
            //{
            //    reverse1 = str[i] + reverse1;
            //    rev2 = rev2 + str[i];
            //}
            //Console.WriteLine(reverse1);
            //Console.WriteLine(rev2);
            //Console.ReadLine();

            int i= 0;
            int j = str.Length - 1;
            bool isPalindrome = false;
            while (i <= j)
            {
                if (str[i].Equals(str[j]))
                {
                    isPalindrome = true;
                    break;
                }
            }
            if (isPalindrome)
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
