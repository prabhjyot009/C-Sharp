using System;

namespace CSharp
{
    class InstanceLocalVar
    {
        // difference between instance and local variable
        int b=10; // instance variable
        static void Main(string[] args)
        {
            int a = 20; // local variable
            InstanceLocalVar obj = new InstanceLocalVar();
            Console.WriteLine(a);
            Console.WriteLine(obj.b);
            Console.ReadLine();
        }
    }
}
