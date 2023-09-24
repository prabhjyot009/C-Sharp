using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class PatternNine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows:");
            int noOfrows = Int32.Parse(Console.ReadLine());
            for(int row = noOfrows; row >= 1; row--)
            {
                for(int cols = row; cols >= 1; cols--)
                {
                    Console.Write(row);
                }
                Console.WriteLine();
            }
        }
    }
}
