namespace Basics.S006_Enums;

public static class SystemEnum {
    public static void UserMain() {
        const EmployeeEnum e = EmployeeEnum.Manager;

        Console.WriteLine("EmployeeEnum uses {0} for storage.", Enum.GetUnderlyingType(e.GetType()));
        Console.WriteLine();

        Console.WriteLine("EmployeeEnum uses {0} for storage.", Enum.GetUnderlyingType(typeof(EmployeeEnum)));
    }
}