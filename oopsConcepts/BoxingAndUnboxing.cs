using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcepts
{
    class BoxingAndUnboxing
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i; // Boxing
            int j = (int)o; // Unboxing
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
