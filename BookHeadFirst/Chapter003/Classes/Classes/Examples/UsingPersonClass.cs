using Classes.Models;

namespace Classes.Examples;

public static class UsingPersonClass {
    public static void Run() {
        var person = new Person("Diego", new DateOnly(1988, 1, 22));

        Console.WriteLine(person.Name);
        Console.WriteLine(person.BirthDate);
        Console.WriteLine();

        person.Name = "Amanda";
        person.BirthDate = new DateOnly(1993, 10, 16);

        Console.WriteLine(person.Name);
        Console.WriteLine(person.BirthDate);
    }
}