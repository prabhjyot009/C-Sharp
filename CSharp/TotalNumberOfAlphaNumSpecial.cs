using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class TotalNumberOfAlphaNumSpecial
    {
        static void Main(string[] args)
        {
            string str = "sir#23";
            int l = str.Length;
            int digit=0, special=0, alpha = 0;
            int i=0;
            while (i<l)
            {
                if (str[i]>='a' && str[i]<='z' || str[i] >= 'A' && str[i] <= 'Z')
                {
                    alpha++;
                }
                else if (str[i]>='0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    special++;
                }
                i++;
            }
            Console.Write("Number of Alphabets in the string is : {0}\n", alpha);
            Console.Write("Number of Digits in the string is : {0}\n", digit);
            Console.Write("Number of Special characters in the string is : {0}\n\n", special);
        }
    }
}
