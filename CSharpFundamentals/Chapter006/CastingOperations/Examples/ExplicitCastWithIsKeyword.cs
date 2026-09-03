using CastingOperations.Models;

namespace CastingOperations.Examples;

internal static class ExplicitCastWithIsKeyword {
    internal static void Run() {
        object[] objects = [
            new SalesPerson("John", 2100),
            "Diego",
            new SalesPerson("Jane", 2250),
            new Manager("Julia", 3050),
            100.5f,
            new Manager("Betty", 3100)
        ];

        foreach (object obj in objects) {
            if (obj is not Employee) continue;

            var employee = (Employee)obj;

            GivePromotion(employee);
        }

        Console.WriteLine();

        foreach (object obj in objects) {
            if (obj is Employee employee) {
                GivePromotion(employee);
            }
        }

        Console.WriteLine();

        foreach (object obj in objects) {
            if (obj is not Employee employee) {
                continue;
            }

            GivePromotion(employee);
        }
    }

    private static void GivePromotion(Employee employee) {
        Console.WriteLine($"{employee.Name} was promoted!");
    }
}