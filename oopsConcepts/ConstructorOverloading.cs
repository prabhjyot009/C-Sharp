using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcepts
{
    //We can create multiple constructors
    //we cannot create 2 default constructor
    //constructor overloading is same class different parameters.
    //decides on compile time
    class ConstructorOverloading
    {
        public ConstructorOverloading()
        {
            Console.WriteLine("this is first constructor");
        }
        public ConstructorOverloading(int a,int b)
        {
            Console.WriteLine("this is second constructor {0}", (a + b));
        }
        public ConstructorOverloading(int a,int b,int c)
        {
            Console.WriteLine("this is third constructor {0}", (a + b + c));
        }
        public ConstructorOverloading(string a,string b,string c)
        {
            Console.WriteLine("this is fourth constructor {0}", (a + b + c));
        }
        static void Main(string[] args)
        {
            ConstructorOverloading c = new ConstructorOverloading();
            ConstructorOverloading c1 = new ConstructorOverloading(10, 20);
            ConstructorOverloading c2 = new ConstructorOverloading(10, 20, 30);
            ConstructorOverloading c3 = new ConstructorOverloading("A", "B", "C");
        }
    }
}
