namespace Chapter004.Tuples;

public static class Example004 {
    public static void Run() {
        // Deconstructing Tuples

        (string name, int age) bob = ("Bob", 23);
        
        (string bobName, int bobAge) = bob;

        (string personName, int personAge) = GetPerson();
        
        Console.WriteLine($"{bobName}, {bobAge}");
        Console.WriteLine($"{personName}, {personAge}");
    }

    private static (string name, int age) GetPerson() {
        return ("Person", 32);
    }
}