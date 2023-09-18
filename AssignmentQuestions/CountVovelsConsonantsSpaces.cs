using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQuestions
{
    class CountVovelsConsonantsSpaces
    {
        static void Main(string[] args)
        {
            string str = "Take u forward is Awesome";
            int vovels = 0;
            int consonants = 0;
            int spaces = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                ch = char.ToLower(str[i]);
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vovels++;
                }
                else if (ch == ' ')
                {
                    spaces++;
                }
                else
                {
                    consonants++;
                }
            }
            Console.WriteLine("Vovels: " + vovels);
            Console.WriteLine("Consonants: " + consonants);
            Console.WriteLine("Spaces: " + spaces);
        }
    }
}
