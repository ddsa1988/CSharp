using Encapsulation.Models;

namespace Encapsulation.Examples;

internal static class UsingEmployee1 {
    internal static void Run() {
        var emp1 = new Employee1("Diego", 1000f);
        var emp2 = new Employee1("Amanda", 2000f);

        Console.WriteLine(emp1);
        Console.WriteLine(emp2);
        Console.WriteLine();

        try {
            emp1.SetSalary(-500f);
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine();

        try {
            emp2.SetName("This is a text that wil throw an exception");
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}