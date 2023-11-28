using System;

namespace Day6_7
{
    class PS16
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Dog();
            Animal animal2 = new Cat();
            animal1.eat();
            animal2.eat();

        }

        class Animal
        {
            public virtual void eat()
            {
                Console.WriteLine("Eating...");
            }
        }

        class Dog : Animal
        {
            public override void eat()
            {
                Console.WriteLine("Eating bread...");
            }
        }

        class Cat : Animal
        {
            public override void eat()
            {
                Console.WriteLine("Eating rat...");
            }
        }

    }
}
