namespace Chapter003.Interfaces;

public static class Example005 {
    public static void Run() {
        // From C# 8, you can add a default implementation to an interface member, making it optional to implement.

        var logger1 = new Logger1();
        var logger2 = new Logger2();

        // Default implementations are always explicit, so if a class implementing ILogger fails
        // to define a Log method, the only way to call it is through the interface.

        //logger1.Log(); // Compile-time error

        ((ILogger)logger1).Log("Test");
        logger2.Log("Test");
    }

    private class Logger1 : ILogger { }

    private class Logger2 : ILogger {
        public void Log(string text) {
            Console.WriteLine("Logger2: " + text);
        }
    }

    private interface ILogger {
        public void Log(string text) {
            Console.WriteLine(text);
        }
    }
}