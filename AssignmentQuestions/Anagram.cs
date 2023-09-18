using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQuestions
{
    class Anagram
    {
        static void Main(string[] args)
        {
            string str1 = "CAT";
            string str2 = "ACt";

            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1.ToUpper() == val2.ToUpper())
            {
                Console.WriteLine("is Anagram");
            }
            else
            {
                Console.WriteLine("is not anagram");
            }
            Console.ReadLine();
        }
    }
}
