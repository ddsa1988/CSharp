using Encapsulation.Models;

namespace Encapsulation.Examples;

internal static class UsingEmployee2 {
    internal static void Run() {
        var emp1 = new Employee2("Diego", 1000f);
        var emp2 = new Employee2("Amanda", 2000f);

        Console.WriteLine(emp1);
        Console.WriteLine(emp2);
        Console.WriteLine();

        try {
            emp1.Salary = -500f;
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine();

        try {
            emp2.Name = "This is a text that wil throw an exception";
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine();

        emp1.Salary += 200f;
        Console.WriteLine(emp1);
    }
}