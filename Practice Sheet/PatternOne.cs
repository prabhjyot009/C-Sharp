using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class PatternOne
    {
        static void Main(string[] args)
        {
            //int NoOfRows = 5;
            //for (int rows = 1; rows <= NoOfRows; rows++)
            //{
            //    for (int cols = 1; cols <= rows; cols++)
            //    {
            //        Console.Write(rows+" ");
            //    }
            //    Console.WriteLine();
            //}
            int NoOfRows = 6;
            for (int i = 1; i < NoOfRows; i++)
            {
                for (global::System.Int32 j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
