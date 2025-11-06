namespace Examples.OptionalParameter;

public static class Example001 {
    public static void Run() {
        Greeting();
        Greeting("Good morning!");
    }

    private static void Greeting(string message = "Hello!") {
        Console.WriteLine(message);
    }
}