using System;

namespace Practice_Sheet
{
    class PatternSeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows:");
            int noOfrows = Int32.Parse(Console.ReadLine());
            for (int rows = noOfrows; rows>=1; rows--)
            {
                for(int cols = noOfrows; cols >=rows; cols--)
                {
                    Console.Write(cols);
                }
                Console.WriteLine();
            }
        }
    }
}
