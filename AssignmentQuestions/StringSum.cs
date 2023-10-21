using System;
using System.Linq;
namespace AssignmentQuestions
{
    class StringSum
    {
        static void Main()
        {
            string input = "1xy23";
            int sum = 0;
            foreach (char character in input)
            {
                if (char.IsDigit(character))
                {
                    sum += int.Parse(character.ToString());
                }
            }
            Console.WriteLine("Sum of digits in the string: " + sum);
        }
    }

}