using System;

namespace oopsConcepts
{
    class person
    {
        public static string PersonName;
        public static int PersonAge;

        static person()
        {
            PersonName = "Singh";
            PersonAge = 23;
            Console.WriteLine("Static constructor invoked");
        }
        public person()
        {
            Console.WriteLine("default constructor invoked");
        }
        public void getDetails()
        {
            Console.WriteLine("Person name is: {0}",PersonName);
            Console.WriteLine("Person Age is {0}",PersonAge); 
        }
    }

    class Static_Constructor
    {
        static void Main(string[] args)
        {
            //A static constructor is used initialize static variables 
            //of the class and to perform a particular action only once.

            //Static constructor is called only once, no matter how 
            //objects you create.

            /*Static constructor is called before instance
             * (default or parameterized)constructor
             * 
             * A static contructor does not take any parameters
             * and does not use any access modifiers
             */

            person brar = new person();
            person yo = new person();
            yo.getDetails();
            Console.ReadLine();
        }
    }
}
