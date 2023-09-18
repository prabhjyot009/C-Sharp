using System;

namespace CSharp
{
    class PalindromeString
    {
        static void Main(string[] args)
        {
            string str = "abacd";
            string reverse1 = "";
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

            for(int i = 0; i < str.Length; i++)
            {
                reverse1 = str[i] + reverse1;
                rev2 = rev2 + str[i];
            }
            Console.WriteLine(reverse1);

            Console.WriteLine(rev2);
            Console.ReadLine();
        }
    }
}
