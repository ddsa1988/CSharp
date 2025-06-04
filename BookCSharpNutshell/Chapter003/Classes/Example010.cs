namespace Chapter003.Classes;

public static class Example010 {
    public static void Run() {
        // A static constructor executes once per type rather than once per instance. A type can define
        // only one static constructor, and it must be parameterless and have the same  name as the type

        Test.Greeting("Hello World");
    }

    private class Test {
        public static readonly int X = 3;

        static Test() {
            Console.WriteLine("Static constructor called.");
            Console.WriteLine("{0} = {1}", nameof(X), X);
        }

        public static void Greeting(string msg) {
            Console.WriteLine("Greeting: " + msg);
        }
    }
}