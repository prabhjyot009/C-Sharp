using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQuestions
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = "Take u forward is Awesome";
            string rev = "";
            for (int i = str.Length-1; i >=0; i--)
            {
                rev += str[i].ToString();
            }
            Console.WriteLine(rev);
        }
    }
}
