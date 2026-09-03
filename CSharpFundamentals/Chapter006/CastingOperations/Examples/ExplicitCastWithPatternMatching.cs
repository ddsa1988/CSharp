using CastingOperations.Models;

namespace CastingOperations.Examples;

internal static class ExplicitCastWithPatternMatching {
    internal static void Run() {
        Employee[] employees = [
            new SalesPerson("John", 2100) { SalesNumber = 50 },
            new SalesPerson("Jane", 2250) { SalesNumber = 100 },
            new Manager("Julia", 3050) { StockOptions = 10 },
            new Manager("Betty", 3100) { StockOptions = 12 }
        ];

        foreach (Employee employee in employees) {
            GivePromotion(employee);
        }
    }

    private static void GivePromotion(Employee employee) {
        Console.WriteLine($"{employee.Name} was promoted!");

        switch (employee) {
            case SalesPerson salesPerson:
                Console.WriteLine($"{employee.Name} made {salesPerson.SalesNumber} sale(s)!");
                break;
            case Manager manager:
                Console.WriteLine($"{employee.Name} had {manager.StockOptions} stock options...");
                break;
            default:
                Console.WriteLine($"Unable to promote {employee.Name}. Wrong employee type.");
                break;
        }
    }
}