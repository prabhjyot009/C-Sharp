using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class RangePrime
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                if(i==0 || i == 1)
                {                    
                    continue;
                }
                int flag = 1;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
