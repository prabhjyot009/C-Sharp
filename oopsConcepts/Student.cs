using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcepts
{
    class Student
    {
        int rollno;
        string name;
        int age;
        int standard;
        public void setStudent(int rollno, string name, int age,int standard)
        {
            this.rollno = rollno;//this keyword(this.rollno) is used to refer class properties and assigning it to(rollno) the argument value.
            this.name = name;
            this.age = age;
            this.standard = standard;
        }
        public void getStudent()
        {
            Console.WriteLine("Your Roll No is: {0}",this.rollno);
            Console.WriteLine("Your name is: {0}",this.name);
            Console.WriteLine("Your age is: {0}",this.age);
            Console.WriteLine("Your standard is: {0}",this.standard);
        }
        static void Main(string[] args)
        {
            //user defined:
            Console.WriteLine("Enter Roll no:");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name no:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age no:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Standard no:");
            int standard = int.Parse(Console.ReadLine());

            //pre defined:
            //Student Ali = new Student();//new keyword will assign a new location to this object in our memory.
            //Ali.setStudent(26,"singh",20,3);
            //Ali.getStudent();
            //Console.ReadLine();
        }
    }
}
