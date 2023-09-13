using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class StringsEqualOrNot
    {
        static void Main(string[] args)
        {
            string str1 = "HEllo sir", str2 = "Hello sir";
            int i = 0, flag = 0, l1 = str1.Length, l2 = str2.Length;
            int result = 0;
            if (l1 == l2)
            {
                for (i = 0; i < l1; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        result = 1;
                        i = l1;
                    }
                }
            }

            if (l1 == l2)
                flag = 0;
            else if (l1 > l2)
                flag = 1;
            else if (l1 < l2)
                flag = -1;

            if (flag == 0)
            {
                if (result == 0)
                    Console.Write("The length of both strings are equal and \nalso, both strings are same.\n\n");
                else
                    Console.Write("The length of both strings are equal and \nbut they are not same.\n\n");
            }
            else if (flag == -1)
            {
                Console.Write("\nThe length of the first string is smaller than second.\n\n");
            }
            else
            {
                Console.Write("\nThe length of the first string is greater than second.\n\n");
            }
            Console.ReadLine();
        }
    }
}
