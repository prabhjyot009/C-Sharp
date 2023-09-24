using System;

namespace Practice_Sheet
{
    class PatternThirteen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows:");
            int noOfrows = Int32.Parse(Console.ReadLine());
            for (int row = 1; row <= noOfrows; row++)
            {
                for(int cols = row; cols <= noOfrows; cols++)
                {
                    Console.Write(cols);
                }   
                Console.WriteLine();
            }
        }
    }
}
