namespace Chapter004.Tuples;

public static class Example002 {
    public static void Run() {
        // Return tuples from a method
        
        Console.WriteLine(GetPerson());
    }

    private static (string, int) GetPerson() {
        return ("Person", 32);
    }
}