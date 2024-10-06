using CSharpLearning.AbstractVersusInterface;
using CSharpLearning.ConcereteClassVersusStaticClass;
using CSharpLearning.Extensions_Methods;
using CSharpLearning.SolidPrinciples.OpenClosedPrinciple;
using CSharpLearning.SolidPrinciples;
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


#region OpenClosedPrincipleExample
// Using Email Notification
INotificationService emailService = new EmailNotificationService();
var productManagerWithEmail = new OpenClosedPrinciple(emailService);
var product1 = new Product(1, "Laptop");
productManagerWithEmail.AddProduct(product1); // This will send an email notification

// Using SMS Notification
INotificationService smsService = new SMSNotificationService();
var productManagerWithSMS = new OpenClosedPrinciple(smsService);
var product2 = new Product(2, "Smartphone");
productManagerWithSMS.AddProduct(product2); // This will send an SMS notification 
#endregion
