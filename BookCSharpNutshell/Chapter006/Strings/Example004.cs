namespace Chapter006.Strings;

public static class Example004 {
    public static void Run() {
        // Accessing characters within a string

        const string greeting = "Hello";

        for (int i = 0; i < greeting.Length; i++) {
            Console.Write(greeting[i] + " ");
        }
    }
}