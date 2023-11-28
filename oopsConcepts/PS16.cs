using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcepts
{
//WAP to demonstrate polymorphism that enables you to invoke derived class methods through base class reference variables at runtime.
    class PER
    {
        private string name;
        private int age;

        public PER(string name, int age)
        {
            this.name=name;
            this.age=age;
        }

        public virtual void display()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
        }
    }

    class Employee : PER
    {
        private int empId;
        private string dept;

        public Employee(string name, int age, int empId, string dept) : base(name, age)
        {
            this.empId=empId;
            this.dept=dept;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("EmpId: {0}", empId);
            Console.WriteLine("Dept: {0}", dept);
        }
    }

    class PS16              
    {
        static void Main(string[] args)
        {
            PER p = new PER("John", 36);
            p.display();
            Console.WriteLine();

            Employee e = new Employee("David", 30, 1001, "IT");
            e.display();
            Console.WriteLine();

            PER p1 = new Employee("Mike", 40, 1002, "HR");
            p1.display();
            Console.WriteLine();
        }
    }   


}
