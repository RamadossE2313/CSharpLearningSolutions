using CSharpLearning.ConcereteClassVersusStaticClass;
using CSharpLearning.Extensions_Methods;

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
Console.WriteLine(StaticClass.Name);



