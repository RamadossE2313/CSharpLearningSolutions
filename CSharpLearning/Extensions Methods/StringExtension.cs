namespace CSharpLearning.Extensions_Methods
{
    public static class StringExtension
    {
        public static string AddDefaultCharectWithString(this string input)
        {
            return $"DefaultValue {input}";
        }
    }
}
