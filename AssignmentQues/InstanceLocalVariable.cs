using System;

namespace CSharpPractice
{
    class InstanceLocalVariable
    {
        //instance variable
        int a = 10;
        public static void Main()
        {
            Class1 obj = new Class1();
            Console.WriteLine(obj.a);
        }
    }
}
