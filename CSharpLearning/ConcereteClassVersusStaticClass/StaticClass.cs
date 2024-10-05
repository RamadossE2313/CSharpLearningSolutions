namespace CSharpLearning.ConcereteClassVersusStaticClass
{
    // Static Class: Cannot be instantiated, contains only static members, and is typically used for utility functions.
    // utilty or helper class, like extention methods
    // static class can't have base classes
    // static class can't implment interfaces
    // can't use sealed in the static class, Static classes are sealed
    // Static classes maintain state using static fields, but this state is shared across all usages and is not tied to any instance.
    
    //public static class StaticClass : StaticBaseClass
    //public static class StaticClass : IA

    public static class StaticClass
    {
        public static int Id { get; set; }
        public static string Name { get; set; }

        private static int id1;
        private static string name1;

        public static int Id1 { get { return id1; } }
        public static string Name1 { get { return name1; } }

        // static constructor can't have parameterized constructor
        //static StaticClass(int id, string name){}

        static StaticClass()
        {
            id1 = 1;
        }

    }

    public static class StaticBaseClass
    {
        public static int BaseId { get; set; } = 1;
    }

    public interface IA
    {
        int Id { get; set; }
    }
}
