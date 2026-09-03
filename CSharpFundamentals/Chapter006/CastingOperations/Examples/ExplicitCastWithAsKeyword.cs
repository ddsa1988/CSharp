using CastingOperations.Models;

namespace CastingOperations.Examples;

internal static class ExplicitCastWithAsKeyword {
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
            var employee = obj as Employee;

            if (employee == null) continue;

            GivePromotion(employee);
        }
    }

    private static void GivePromotion(Employee employee) {
        Console.WriteLine($"{employee.Name} was promoted!");
    }
}