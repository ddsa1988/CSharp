namespace Chapter003.Interfaces;

public static class Example006 {
    public static void Run() {
        // An interface can also declare static members. There are two kinds of static interface members:
        // Static nonvirtual interface members;
        // Static virtual/abstract interface members.

        Console.WriteLine(CustomerTest.Description());
        Console.WriteLine(CustomerTest.Category());
    }

    private class CustomerTest : ITypeDescribable {
        // Implement an abstract member is mandatory
        public static string Description() {
            return "Description";
        }

        // Implement a virtual member is optional
        public static string Category() {
            return "Category";
        }
    }

    private interface ILogger {
        // Static nonvirtual interface members
        public static string Prefix { get; set; } = string.Empty;

        public void Log(string message) {
            Console.WriteLine(Prefix + message);
        }
    }

    private interface ITypeDescribable {
        // Static abstract interface members.
        public static abstract string Description();

        // Static virtual interface members.
        public static virtual string Category() {
            return "null";
        }
    }
}