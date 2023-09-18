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
            string temp="";
            int sum = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    temp += c;
                }
                else
                {
                    if (temp.Length > 0)
                    {
                        sum += int.Parse(temp);
                        temp = "";
                    }         
                }
            }
            Console.WriteLine(sum+=int.Parse(temp));
            Console.ReadLine();
        }


    }
}
