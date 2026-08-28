using PartialClasses.Models;

namespace PartialClasses.Examples;

internal static class UsingPartialClass {
    internal static void Run() {
        var emp1 = new Employee("Diego", 1000f);
        var emp2 = new Employee("Amanda", 2000f, new DateTime(1993, 10, 16));

        Console.WriteLine(emp1);
        Console.WriteLine(emp2);
        Console.WriteLine(emp2.BirthDate);
    }
}