namespace CSharpLearning.StaticVersusSingleton
{
    // A singleton class allows only one instance of itself to be created and provides a global point of access to that instance.
    // Used when a single instance of a class is required to coordinate actions across the system. Common in scenarios like configuration settings or logging.
    // A singleton class can inherit from other classes and can also implement interfaces.
    public sealed class SingletonClass
    {
        private static SingletonClass instance = null;
        private static readonly object lockObject = new object();

        // Private constructor to prevent instantiation
        private SingletonClass() { }

        public static SingletonClass Instance
        {
            get
            {
                if (instance == null)
                {
                    Console.WriteLine("Inside of instance null");
                    // lock will prevent entering multiple threads, it will make to work one by one
                    lock (lockObject)
                    {
                        Console.WriteLine("Inside lock object");
                        if (instance == null)
                        {
                            instance = new SingletonClass();
                            Console.WriteLine("Instance createad");
                        }
                    }
                }
                return instance;
            }
        }
    }


}
