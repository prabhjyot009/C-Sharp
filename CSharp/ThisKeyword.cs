using System;

namespace CSharp
{
    class ThisKeyword
    {
        int a = 10;
        public void Display(int a)
        {
            Console.WriteLine("Value of local variable is {0}", a);
            Console.WriteLine("Value of instance variable is {0}", this.a); //in this this.a is used to refer instance variable
        }
        static void Main(string[] args)
        {
            ThisKeyword obj = new ThisKeyword();
            obj.Display(20);
            Console.ReadLine();
        }
    }
}
