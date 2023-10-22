using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcepts
{
    class ParametrizedConstructor
    {
        //instance variables are unique for every
        //different object that we create
            int EmpId;
            string EmpName;
            int EmpAge;
            public ParametrizedConstructor(int EmpId, string EmpName, int EmpAge)
            {
                this.EmpId = EmpId;
                this.EmpName = EmpName;
                this.EmpAge = EmpAge;
            }
            public int getId()
            {
                return this.EmpId;
            }
            public string getName()
            {
                return this.EmpName;
            }
            public int getAge()
            {
                return this.EmpAge;
            }
            static void Main(string[] args)
            {
                ParametrizedConstructor singh = new ParametrizedConstructor(11, "Singh", 23);
                ParametrizedConstructor brar = new ParametrizedConstructor(12, "Brar", 20);
                Console.WriteLine("Employee Id is {0}", singh.getId());
                Console.WriteLine("Employee Name is {0}", singh.getName());
                Console.WriteLine("Employee Age is {0}", singh.getAge());
                Console.WriteLine("------------------------");
                Console.WriteLine("Employee Id is {0}", brar.getId());
                Console.WriteLine("Employee Name is {0}", brar.getName());
                Console.WriteLine("Employee Age is {0}", brar.getAge());
                Console.ReadLine();
            }
        }
    }
