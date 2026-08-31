using BasicInheritance.Models;

namespace BasicInheritance.Examples;

internal static class UsingEmployeeClassHierarchy {
    internal static void Run() {
        var salesPerson = new SalesPerson("John", 1000) { SalesNumber = 50 };
        var manager = new Manager("Mayke", 2000) { StockOptions = 5 };

        Console.WriteLine(salesPerson);
        Console.WriteLine(manager);
    }
}