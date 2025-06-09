namespace Chapter004.Tuples;

public static class Example003 {
    public static void Run() {
        // Naming Tuple Elements
        
        (string name, int age) bob = ("Bob", 42);
        (string name, int age) person = GetPerson();
        
        Console.WriteLine(bob);
        Console.WriteLine(person);
        
        Console.WriteLine();
        
        Console.WriteLine("{0} = {1}", nameof(bob.name), bob.name);
        Console.WriteLine("{0} = {1}", nameof(person.name), person.name);
    }
    
    private static (string name, int age) GetPerson() {
        return ("Person", 32);
    }
}