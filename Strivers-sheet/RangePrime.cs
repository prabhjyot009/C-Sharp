using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_sheet
{
    class RangePrime
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 19;

            for (int i = n1; i <=n2; i++)
            {
                if(i == 1 || i == 0)
                {
                    continue;
                }
                int flag = 1;
                for (int j = 2; j < i/2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }                
                if(flag == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
