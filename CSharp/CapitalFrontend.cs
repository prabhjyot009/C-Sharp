using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class CapitalFrontend
    {
        static void Main(string[] args)
        {
            //   String str = "Singh";
            //   StringBuilder sb = new StringBuilder("Brar");
            //   Console.WriteLine(str);
            //   Console.WriteLine(sb);

            //   sb[0] = 'A';
            ///*   str[0] = 'u';*/
            //   Console.WriteLine(str);
            //   Console.WriteLine(sb);

            //   sb[sb.Length - 1] = 'Y';

            //   Console.WriteLine(str);
            //   Console.WriteLine(sb);
            string s = "take me forward";
            string[] arr = s.Split();
            string ans = "";
            foreach (string item in arr)
            {
                StringBuilder str=new StringBuilder(item);
                char ch = str[0];
                
            }
        }

        
    }
}
