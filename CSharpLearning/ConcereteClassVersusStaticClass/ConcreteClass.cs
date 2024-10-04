using System.ComponentModel;

namespace CSharpLearning.ConcereteClassVersusStaticClass
{
    //Concrete Class
    // Can be instantiated, contains both static and instance members, and is used to define objects with specific behaviors and properties.
    // Can have base class
    //public class ConcreteClass : BaseClassA

    // Can't have multiple base class, it will create ambiguity problem (Explained in the down)
    //public class ConcreteClass : BaseClassA, BaseClassB


    // Concrete class example
    public class ConcreteClass : BaseClassA
    {
        // Can have properties
        public int id { get; set; }

        // Can have fields
        private string _name;
        public string Name { get { return _name; } }

        // Can have constructor
        public ConcreteClass(string Name)
        {
            Console.WriteLine("constructor executed");
            _name = Name;
        }


        // can have static members

        public static string Gender { get; set; }

        // can have static constructor
        static ConcreteClass()
        {
            Console.WriteLine("static constructor executed");
            Gender = "Male";
        }
    }


    #region Ambiguity Problem
    public class BaseClassA { public void DoSomething() { Console.WriteLine("A"); } }
    public class BaseClassB { public void DoSomething() { Console.WriteLine("B"); } }
    
    // When we create instance of the BaseClassC and call DoSomething method, it doesn't know which method to call it. it's called ambiguity problem
    //public class BaseClassC : BaseClassA, BaseClassC { } 
    #endregion
}
