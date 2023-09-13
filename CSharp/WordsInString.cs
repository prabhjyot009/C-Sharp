using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class WordsInString
    {
        static void Main(string[] args)
        {
            int i, l=0, wrd=1;
            String str = "HEllo Sir";
            while (l<=str.Length-1)
            {
                if (str[l]==' ' || str[l]=='\n' || str[l]=='\t')
                {
                    wrd++;
                }
                l++;
            }
            Console.Write("Total number of words in a string: " + wrd);
            Console.ReadLine();
        }
    }
}
