using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Fibonacci
    {
        static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int count = Int32.Parse(Console.ReadLine());
            Console.Write(p1+" "+p2);
            for (int i = 2; i < count; i++)
            {
                p3 = p1 + p2;
                Console.Write(" "+p3);
                p1 = p2;
                p2 = p3;
            }
            Console.WriteLine();
        }
    }
}
