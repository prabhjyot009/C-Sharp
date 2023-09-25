using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Sheet
{
    class NPrime
    {
        static bool isprime(int num)
        {
            if(num==0 || num == 1)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int num = 10;
            for (int i = 1; i <= num; i++)
            {
                if (isprime(i))
                {
                    Console.Write(i+" ");
                }
            }
        }
        
    }
}
