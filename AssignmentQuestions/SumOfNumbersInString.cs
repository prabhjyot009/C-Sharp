using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQuestions
{
    class SumOfNumbersInString
    {
        static void Main(string[] args)
        {
            //string str = "1xyz23";
            //char[] ch = str.ToCharArray();
            //int sum = 0;
            //for (int i = 0; i < ch.Length; i++)
            //{
            //    if (char.IsDigit(ch[i]))
            //    {
            //        sum += int.Parse(ch[i].ToString());
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();
            string str = "1xyz23";
            string temp= "0";
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsDigit(ch))
                {
                    temp += ch;
                }
                else
                {
                    sum += int.Parse(temp);
                    temp = "0";
                }

            }
            Console.WriteLine(sum + int.Parse(temp));
            Console.ReadLine();
        }


    }
}
