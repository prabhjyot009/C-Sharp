using System;

namespace Practice_Sheet
{
    class BaseClass
    {
        public void ShowMessage()
        {
            Console.WriteLine("This is a method from the BaseClass.");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void ShowMessage()
        {
            Console.WriteLine("This is a method from the DerivedClass.");
        }
    }

    class PS15
    {
        static void Main()
        {
            BaseClass baseObj = new DerivedClass();
            DerivedClass derivedObj = new DerivedClass();

            baseObj.ShowMessage(); derivedObj.ShowMessage();
            ((BaseClass)derivedObj).ShowMessage();
        }
    }

}
