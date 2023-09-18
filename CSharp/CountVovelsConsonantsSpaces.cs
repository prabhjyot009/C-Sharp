using System;

namespace CSharp
{
    class CountVovelsConsonantsSpaces
    {
        static void Main(string[] args)
        {
            string str= "Take u forward is Awesome";
            int vovels = 0;
            int consonants = 0;
            int spaces = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if(ch>='a' && ch <= 'z')
                {
                    ch = char.ToLower(str[i]);
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        vovels++;

                    }
                    else
                    {
                        consonants++;
                    }
                }
                if (ch == ' ')
                {
                    spaces++;
                }
            }   
        }
    }
}
