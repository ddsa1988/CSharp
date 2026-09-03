using CastingOperations.Models;

namespace CastingOperations.Examples;

internal static class ImplicitCast {
    internal static void Run() {
        Employee[] employees = [
            new SalesPerson("John", 2100),
            new SalesPerson("Jane", 2250),
            new Manager("Julia", 3050),
            new Manager("Betty", 3100)
        ];

        foreach (Employee employee in employees) {
            GivePromotion(employee);
        }
    }

    private static void GivePromotion(Employee employee) {
        Console.WriteLine($"{employee.Name} was promoted!");
    }
}