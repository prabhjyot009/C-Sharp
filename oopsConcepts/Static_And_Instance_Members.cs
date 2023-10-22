using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsConcepts
{
    //bydefault in csharp access modifer is private
    class Studentt
    {
        public int rollNo;
        public string firstname;
        public string lastname;
        public int age;
        //static variable remains same for every object:
        public static string schoolname = "DPS Ranipur";
        public static int fees = 5000;
        //instance method:both static and instance variables can accessed.
        public void printFullName()
        {
            string fullname = this.firstname + " " + this.lastname;
            Console.WriteLine("Your full name is {0}",fullname);
            Console.WriteLine(schoolname);//static variable
        }
        //static method:only static variables can accessed.
        public static int getFees()
        {
            return fees;
        }
        public static int getFeesAnnualIncreement(int fee)
        {

            return fee /10;
        }
    }
    class Static_And_Instance_Members
    {
        static void Main(string[] args)
        {
            Studentt Singh = new Studentt();
            Singh.rollNo = 26;
            Singh.firstname = "Singh";
            Singh.lastname = "Brar";
            Singh.age = 23;
            Singh.printFullName();

            Studentt Brar = new Studentt();
            Brar.rollNo = 23;
            Brar.firstname = "Brar";
            Brar.lastname = "Singh";
            Brar.age = 26;
            Brar.printFullName();
            Console.WriteLine(Singh.rollNo+" "+Singh.firstname+" "+Singh.lastname+" "+Singh.age);
            Console.WriteLine(Studentt.schoolname);
            Console.WriteLine(Brar.rollNo+" "+Brar.firstname+" "+Brar.lastname+" "+Brar.age);
            //for static it uses class name for calling:
            Console.WriteLine(Studentt.schoolname);
            Console.WriteLine(Studentt.getFees());
            Console.WriteLine(Studentt.getFeesAnnualIncreement(1000));
        }
    }
}
