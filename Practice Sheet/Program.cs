using System;
using System.Linq;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        //palindrome string:

        /*Console.Write("Enter string: ");
        string str = Convert.ToString(Console.ReadLine());
        string temp = str;
        string rev = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            rev += str[i];
        }
        if (temp == rev)
        {
            Console.WriteLine("it is palindrome");
        }
        else
        {
            Console.WriteLine("It is not palindrome");
        }*/

        //Count vovels consonants and white spaces:

        //Console.Write("Enter string: ");
        //string str = Convert.ToString(Console.ReadLine());
        //int vovels = 0, consonants = 0, space = 0;
        //for(int i=0;i<str.Length;i++)
        //{
        //    char ch = str[i];
        //    ch = char.ToLower(str[i]);
        //    if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch == 'u')
        //    {
        //        vovels++;
        //    }
        //    else if(ch==' ')
        //    {
        //        space++;
        //    }
        //    else
        //    {
        //        consonants++;
        //    }            
        //}
        //Console.WriteLine(vovels);
        //Console.WriteLine(space);
        //Console.WriteLine(consonants);

        //remove vovels:

        //Console.Write("Enter string: ");
        //string str = Convert.ToString(Console.ReadLine());
        //string str1 = "";
        //for(int i=0;i<str.Length;i++)
        //{
        //    char ch= str[i];
        //    ch=char.ToLower(str[i]);
        //    if(ch!='a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u')
        //    {
        //        str1 += ch.ToString();
        //    }
        //}
        //Console.WriteLine(str1);
        //Console.ReadLine();

        //remove white spaces:

        //Console.Write("Enter string: ");
        //string str = Convert.ToString(Console.ReadLine());
        //string str1 = "";
        //for (int i = 0; i < str.Length; i++)
        //{
        //    char ch = str[i];
        //    if (ch != ' ')
        //    {
        //        str1 += ch.ToString();
        //    }
        //}
        //Console.WriteLine(str1);
        //Console.ReadLine();

        //remove expressions:

        //Console.Write("Enter string: ");
        //string str = Convert.ToString(Console.ReadLine());
        //string str1 = "";
        //for (int i = 0; i < str.Length; i++)
        //{
        //    char ch = str[i];
        //    if (char.IsLetter(str[i]))
        //    {
        //        str1 += ch.ToString();
        //    }
        //}
        //Console.WriteLine(str1);
        //Console.ReadLine();

        //add 1xyz23;
        
        //Console.Write("Enter string: ");
        //string str = Convert.ToString(Console.ReadLine());
        //string temp = "";
        //int sum = 0;
        //for (int i = 0; i < str.Length; i++)
        //{
        //    char ch = str[i];
        //    if (char.IsDigit(str[i])){
        //        temp += ch;
        //    }
        //    else
        //    {
        //        sum += int.Parse(temp);
        //        temp = "0";
        //    }
        //}
        //Console.WriteLine(sum+int.Parse(temp));

        //capitalize first and last:

        //Console.Write("Enter string: ");
        //string str = Convert.ToString(Console.ReadLine());
        //string[] word = str.Split();
        //StringBuilder cap = new StringBuilder();
        //foreach (string w in word)
        //{
        //    if (w.Length > 2)
        //    {
        //        string first = w.Substring(0, 1);
        //        string afterfirst = w.Substring(1, w.Length - 2);
        //        string last = w.Substring(w.Length - 1);
        //        cap.Append(first.ToUpper()).Append(afterfirst).Append(last.ToUpper()).Append(" ");
        //    }
        //    else
        //    {
        //        cap.Append(w.ToUpper()).Append(" ");
        //    }
        //}
        //Console.WriteLine(cap);


        Console.Write("Enter string: ");
        string str1 = Convert.ToString(Console.ReadLine());
        Console.WriteLine("");
    }
}