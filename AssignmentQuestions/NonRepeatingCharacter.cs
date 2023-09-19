using System;
using System.Linq;

namespace AssignmentQuestions
{
    class NonRepeatingCharacter
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "world";
            string result = "";
            int str1Length = s1.Length;
            int str2Length = s2.Length;

            for (int i = 0; i < str1Length; i++)
            {
                if (!s2.Contains(s1[i]))
                {
                    result += s1[i];
                }
            }
            for (int i = 0; i < str2Length; i++)
            {
                if (!s1.Contains(s2[i]))
                {
                    result += s2[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
