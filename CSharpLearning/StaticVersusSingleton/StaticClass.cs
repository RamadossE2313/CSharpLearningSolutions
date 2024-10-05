namespace CSharpLearning.StaticVersusSingleton
{
    // A static class cannot be instantiated. It can only contain static members (methods, properties, fields, etc.).
    // Typically used for utility or helper methods that don’t need to maintain state. For example, Math class methods are static.
    // Static classes cannot inherit from other classes and cannot be inherited from. They cannot implement interfaces.
    // Members of a static class are accessed directly through the class name without needing to create an instance

    public static class StaticClass
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
