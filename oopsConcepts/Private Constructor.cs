using System;

namespace oopsConcepts
{
    class Example
    {
        public static int a;
        private Example()
        {

        }
        public static int getIncrement()
        {
            return a++;
        }
       public static void getTiime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
    //class Example2 : Example//cannot access in another class neither we can can create instance of this class
    //{ }
    class Private_Constructor
    {
        static void Main(string[] args)
        {
            //Example e = new Example();//cannot access due to its protection level
            Example.getTiime();
            Example.a=20;
            Console.WriteLine(Example.getIncrement());
                    }
    }
}