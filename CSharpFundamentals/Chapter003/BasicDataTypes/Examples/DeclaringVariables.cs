namespace BasicDataTypes.Examples;

internal static class DeclaringVariables {
    internal static void Run() {
        LocalVariableDeclarations();
        Console.WriteLine();

        DefaultDeclarations();
        Console.WriteLine();

        NewingDataTypes();
    }

    private static void LocalVariableDeclarations() {
        int myInt = 123;
        string myString = "This is a character data.";
        const bool myBool1 = true, myBool2 = false;

        Console.WriteLine(myInt);
        Console.WriteLine(myString);

        myInt = 1456;
        myString = "This is a string data.";

        Console.WriteLine(myInt);
        Console.WriteLine(myString);

        Console.WriteLine(myBool1);
        Console.WriteLine(myBool2);
    }

    private static void DefaultDeclarations() {
        const int myInt = default;
        const string myString = default;
        DateTime myDateTime = default;

        Console.WriteLine($"{myInt}, {myString}, {myDateTime}");
    }

    private static void NewingDataTypes() {
        const bool myBool = new();
        const int myInt = new();
        const double myDouble = new();
        DateTime myDateTime = new();

        Console.WriteLine("{0}, {1}, {2}, {3}", myBool, myInt, myDouble, myDateTime);
    }
}