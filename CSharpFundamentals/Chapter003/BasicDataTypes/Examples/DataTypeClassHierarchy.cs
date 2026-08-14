namespace BasicDataTypes.Examples;

internal static class DataTypeClassHierarchy {
    internal static void Run() {
        // A C# int is a shorthand for System.Int32, which inherits the following members from System.Object
        const int myInt1 = 123;
        const int myInt2 = 456;

        Console.WriteLine("System.Object Functionality =>\n");
        Console.WriteLine($"{myInt1}.ToString(): {myInt1.ToString()}");
        Console.WriteLine($"{myInt1}.GetType(): {myInt1.GetType()}");
        Console.WriteLine($"{myInt1}.GetHashCode(): {myInt1.GetHashCode()}");
        Console.WriteLine($"{myInt1}.Equals({myInt2}): {myInt1.Equals(myInt2)}");
    }
}