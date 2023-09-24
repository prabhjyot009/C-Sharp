using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class PatternFour
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows:");
            int noOfrows = Int32.Parse(Console.ReadLine());
            for (int rows = 1; rows <= noOfrows; rows++)
            {
                for(int cols = rows; cols >= 1; cols--)
                {
                    Console.Write(cols+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
