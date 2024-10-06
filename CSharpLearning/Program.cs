using CSharpLearning.AbstractVersusInterface;
using CSharpLearning.ConcereteClassVersusStaticClass;
using CSharpLearning.Extensions_Methods;
using CSharpLearning.StaticVersusSingleton;

// Extension method example
string name = "Something";
Console.WriteLine(name.AddDefaultCharectWithString());

// Concrete class vs static class examples
ConcreteClass concreteClass = new ConcreteClass("example");
Console.WriteLine(concreteClass.Name);
Console.WriteLine(ConcreteClass.Gender);

// Why we can't have multiple classes for the concrete class
//BaseClassC baseClassC = new BaseClassC();
//baseClassC.DoSomething();

// Static class example 
//Console.WriteLine(StaticClass.Name);

#region TestLockFunctionality
//Task[] tasks = new Task[10];

//// Create multiple tasks (threads) to access the singleton
//for (int i = 0; i < tasks.Length; i++)
//{
//    tasks[i] = Task.Run(() =>
//    {
//        SingletonClass instance = SingletonClass.Instance;
//        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}");
//    });
//}

//// Wait for all tasks to complete
//Task.WaitAll(tasks);

//Console.WriteLine("All threads completed."); 
#endregion