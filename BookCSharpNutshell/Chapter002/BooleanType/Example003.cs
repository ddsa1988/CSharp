namespace Chapter002.BooleanType;

public static class Example003 {
    public static void Run() {
        // The && and || operators short-circuit evaluation when possible.

        const string? name = "Diego";

        if (name != null && name.Length > 0) {
            Console.WriteLine("{0} has {1} characters.", name, name.Length);
        }
    }
}