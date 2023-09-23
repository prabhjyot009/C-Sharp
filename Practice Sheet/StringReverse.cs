using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class StringReverse
    {
        static void Main(string[] args)
        {
            string str = "hello";
            int i = 0;
            int j = str.Length - 1;
            char[] ch = str.ToCharArray();
            while (i < j)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                i++;
                j--;
            }
            Console.WriteLine(ch);
        }
    }
}
