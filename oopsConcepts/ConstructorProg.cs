using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcepts
{
    class ConstructorProg
    {
        //if we are not creating any constructor in our program then
        //csharp complier will automatically create an constructor
        //also known as default constructor.
        public ConstructorProg()
        {
            Console.WriteLine("Constructor invoked");
        }
        static void Main(string[] args)
        {
            ConstructorProg obj = new ConstructorProg();
        }
    }
}
