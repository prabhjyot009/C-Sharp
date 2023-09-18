using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQuestions
{
    class RemoveWhiteSpaces
    {
        static void Main(string[] args)
        {
            string str = "Take u forward is Awesome";
            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch!=' ')
                {
                    str1 += ch.ToString();
                }
            }
            Console.WriteLine(str1);
            Console.ReadLine();
        }
    }
}
