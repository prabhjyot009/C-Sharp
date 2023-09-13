using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Anagarm
    {
        static void Main(string[] args)
        {
            string str1 = "bus";
            string str2 = "ubs";

            char[] ch = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();

            Array.Sort(ch);
            Array.Sort(ch2);
            string val1 = new string(ch);
            string val2 = new string(ch2);

            if (val1==val2)
            {
                Console.WriteLine("both string are equal");
            }
            else
            {

            }
        }
    }
}
