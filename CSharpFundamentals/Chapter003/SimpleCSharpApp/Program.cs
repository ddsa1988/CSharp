namespace SimpleCSharpApp;

public static class Program {
    public static void Main(string[] args) {
        Console.WriteLine("**** My First C# App ****");
        Console.WriteLine("Hello World!");

        foreach (string arg in args) {
            Console.WriteLine($"Arg: {arg}");
        }

        Console.WriteLine(Environment.UserName);
        Console.WriteLine(Environment.MachineName);
        Console.WriteLine(Environment.ProcessorCount);
        Console.WriteLine(Environment.Version);
        Console.WriteLine(Environment.OSVersion.VersionString);
        Console.WriteLine(Environment.CurrentDirectory);

        Console.ReadKey(true);
    }

    // public static int Main(string[] args) {
    //     Console.WriteLine("**** My First C# App ****");
    //     Console.WriteLine("Hello World!");
    //
    //     Console.ReadKey(true);
    //     return 0;
    // }
}