using System;

namespace oopsConcepts
{
    class example
    {
        /*The constructor which creates an object by copying variables from another object is called
         * a copy constructor. The purpose of a copy constructor is to initialize
         * a new instance to the values of an existing instance.
         */
        string name;
        int age;
        public example(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public example(example e)
        {
            this.name = e.name;
            this.age = e.age;
        }
        public void getData()
        {
            Console.WriteLine("Name is: {0}", name);
            Console.WriteLine("Age is: {0}", age);
        }
    }
    class Copy_Constructor
    {
        static void Main(string[] args)
        {
            example obj = new example("Singh", 20);
            obj.getData();
            example obj1 = new example(obj);
            obj1.getData();
            Console.ReadLine();
        }
    }
}