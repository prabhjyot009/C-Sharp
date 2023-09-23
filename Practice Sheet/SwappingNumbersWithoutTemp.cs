using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class SwappingNumbersWithoutTemp
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine(a+" "+b);
        }
    }
}
