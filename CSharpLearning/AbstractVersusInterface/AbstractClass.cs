namespace CSharpLearning.AbstractVersusInterface
{
    // An abstract class is a class that cannot be instantiated
    // it's may contain both abstract methods (without an implementation) and concrete methods (with an implementation).
    // Can contain fields, constructors, and methods (both abstract and non-abstract).
    // Can have access modifiers (public, private, protected, etc.).
    // A class can inherit from only one abstract class (single inheritance), we can have hieraricial level 
    // Used when you want to provide a common base with shared code and/or state, along with some methods that must be implemented by derived classes.
    public abstract class AbstractClass
    {
        private int _id;
        public AbstractClass(int id)
        {
            _id = id;
        }

        public int Id { get { return _id; } }
        public abstract string Name { get; }
    }

    public abstract class AbstractClass2 : AbstractClass
    {
        protected AbstractClass2(int id) : base(id)
        {

        }

        public abstract void Method1();

        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
    class concreteExample2 : AbstractClass2
    {
        public concreteExample2(int id) : base(id)
        {
                
        }

        public override string Name => "sample";

        public override void Method1()
        {
            Console.WriteLine("Concret class");
        }
    }

}
