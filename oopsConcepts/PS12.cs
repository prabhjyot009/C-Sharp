using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcepts
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name=name;
            this.age=age;
        }

        public void display()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
        }
    }

    class PS12 {
        static void Main(string[] args)
        {
                Person p = new Person("John", 36);
            p.display();
            Console.WriteLine();
        }
    }
}
