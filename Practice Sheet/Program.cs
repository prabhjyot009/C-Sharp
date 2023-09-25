using System;

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
        Console.Write("Enter string: ");
        string str = Convert.ToString(Console.ReadLine());
        int vovels = 0, consonants = 0, space = 0;
        foreach (int i in str)
        {
            char ch = str[i];
            ch.ToString().ToLower();
            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch == 'u')
            {
                vovels++;
            }
            if(ch==' ')
            {
                space++;
            }
            else
            {
                consonants++;
            }
        }
        Console.WriteLine(vovels);
        Console.WriteLine(space);
        Console.WriteLine(consonants);
    }
}