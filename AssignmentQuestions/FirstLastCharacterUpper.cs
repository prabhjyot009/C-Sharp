using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQuestions
{
    class FirstLastCharacterUpper
    {        
        static void Main(string[] args)
        {
            string str = "Take u forward is Awesome";
            string[] words = str.Split(' ');
            StringBuilder cap = new StringBuilder();
            foreach (string w in words)
            {
                if (w.Length >= 2)
                {
                    string first = w.Substring(0, 1);
                    string afterfirst = w.Substring(1, w.Length - 1);
                    string last = w.Substring(w.Length - 1);
                    cap.Append(first.ToUpper()).Append(afterfirst).Append(last.ToUpper()).Append(" ");
                }
                else
                {
                    cap.Append(w.ToUpper()).Append(" ");
                }
            }
            Console.WriteLine(cap);
        }
        static void sum
    }
}
