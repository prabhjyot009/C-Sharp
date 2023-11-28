using System;

namespace Day6_7
{
    class Student
    {
        private int id;
        private string name;
        private int passMarks = 35;

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id cannot be negative");
                }
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this.name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
            }
        }

        public int PassMarks
        {
            get
            {
                return this.passMarks;
            }
        }
    }

class PS17
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Id = 101;
            s1.Name = "Mark";
            Console.WriteLine("Student Id = {0}", s1.Id);
            Console.WriteLine("Student Name = {0}", s1.Name);
            Console.WriteLine("Student PassMarks = {0}", s1.PassMarks);
            Console.ReadLine();
        }
    }
    }
