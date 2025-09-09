using Examples.Interface.Interfaces;
using Examples.Interface.Models;

namespace Examples.Interface;

public static class Example002 {
    public static void Run() {
        var manager = new Manager() { Name = "Manager", Id = 1, Salary = 10000 };
        var coordinator = new Coordinator() { Name = "Coordinator", Id = 2, Salary = 8000 };

        var employees = new List<IEmployee> {
            manager,
            coordinator
        };

        foreach (IEmployee employee in employees) {
            Console.WriteLine($"Employee [Id = {employee.Id}, Salary = {employee.Salary:C}]");
        }
    }
}