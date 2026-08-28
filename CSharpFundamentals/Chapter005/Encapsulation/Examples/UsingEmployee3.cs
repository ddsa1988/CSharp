using Encapsulation.Enums;
using Encapsulation.Models;

namespace Encapsulation.Examples;

internal static class UsingEmployee3 {
    internal static void Run() {
        var emp1 = new Employee3("Diego", 1000f, EmployeePayTypeEnum.Salaried, new DateOnly(2022, 1, 15));
        var emp2 = new Employee3("Amanda", 2000f, EmployeePayTypeEnum.Commissioned, new DateOnly(2023, 5, 10));

        Console.WriteLine(emp1);
        Console.WriteLine(emp2);
        Console.WriteLine();
    }
}