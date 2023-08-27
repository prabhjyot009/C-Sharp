using System;

namespace CSharp
{
    class StudentInfo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your roll number: ");
            int rollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            StudentInfo obj = new StudentInfo();
            obj.Display(name, rollNo, age);
            Console.ReadLine();
        }

        public void Display(string name, int rollNo, int age)
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Roll Number: {0}", rollNo);
            Console.WriteLine("Age: {0}", age);
        }
    }
}
