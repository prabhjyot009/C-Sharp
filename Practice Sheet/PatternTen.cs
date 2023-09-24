using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class PatternTen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows:");
            int noOfrows = Int32.Parse(Console.ReadLine());
            for (int row = 1; row <= noOfrows; row++)
            {
                for (int cols = noOfrows; cols >= row; cols--)
                {
                    Console.Write(cols);
                }
                Console.WriteLine();
            }
        }
    }
}
