using System.Reflection;

namespace Examples.TestModels;

public static class Example003 {
    // Using reflection to get value from a private field
    public static void Run() {
        var hasSecret = new HasSecret();

        FieldInfo[] fields = hasSecret.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (FieldInfo field in fields) {
            Console.WriteLine($"{field.Name} = {field.GetValue(hasSecret)}");
        }
    }

    private class HasSecret {
        private string _secret = "xyz";
    }
}