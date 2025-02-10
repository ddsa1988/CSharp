using Basics.S011_ObjectOrientedProgramming.Enums;
using Basics.S011_ObjectOrientedProgramming.Models;

namespace Basics.S011_ObjectOrientedProgramming;

public class EmployeeDemo {
    public static void UserMain() {
        var emp = new Employee("Diego", 10, 200f, EmployeePayTypeEnum.Salaried);

        Console.WriteLine(emp);
    }
}