using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQuestions
{
    class RemoveAllCharactersExceptAlphabets
    {
        static void Main(string[] args)
        {
            string str="t%a^k$e u f#o*r*w@a!r(d is Awe$so^me";
            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (/*(ch >= 'a' && ch <= 'z')||(ch>='A'&&ch<='Z')*/Char.IsLetter(ch))
                {
                    str1 += ch.ToString();
                }
            }   
            Console.WriteLine(str1);
            Console.ReadLine();
        }
    }
}
