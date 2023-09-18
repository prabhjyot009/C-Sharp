using System;

namespace AssignmentQuestions
{
    class Largestword
    {
        static void Main(string[] args)
        {
            string s = "Google Doc Sirrrr";
            string[] a = s.Split(' ');
            string largestword = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length > largestword.Length)
                {
                    largestword = a[i];
                }
            }
            Console.WriteLine(largestword);
         
        }
    }
}