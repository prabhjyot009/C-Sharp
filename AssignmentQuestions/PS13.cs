using System;

namespace AssignmentQuestions
{
    class Employee
    {
        private string name;
        private int age;

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void display()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
        }
    }

    class FullTimeEmployee : Employee
    {
        private int salary;

        public FullTimeEmployee(string name, int age, int salary) : base(name, age)
        {
            this.salary = salary;
        }

        public new void display()
        {
            base.display();
            Console.WriteLine("Salary: {0}", salary);
        }
    }

    class PartTimeEmployee : Employee
    {
        private int salary;
        private int workingHours;

        public PartTimeEmployee(string name, int age, int salary, int workingHours) : base(name, age)
        {
            this.salary = salary;
            this.workingHours = workingHours;
        }

        public new void display()
        {
            base.display();
            Console.WriteLine("Salary: {0}", salary);
            Console.WriteLine("Working Hours: {0}", workingHours);
        }
    }

    class PS13
    {
        static void Main(string[] args)
        {
            //3 employees
            Employee[] employees = new Employee[3];
            Employee employee;
            string name;
            int age;
            int salary;
            int workingHours;
            Console.WriteLine("Enter details of 3 employees: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                Console.Write("Enter age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter salary: ");
                salary = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter working hours: ");
                workingHours = Convert.ToInt32(Console.ReadLine());

                if (workingHours == 8)
                {
                    employee = new FullTimeEmployee(name, age, salary);
                }
                else
                {
                    employee = new PartTimeEmployee(name, age, salary, workingHours);
                }

                employees[i] = employee;
            }

            Console.WriteLine("\nDetails of 3 employees: ");
            for (int i = 0; i < 3; i++)
            {
                employees[i].display();
                Console.WriteLine();
            }
        }
    }
}
