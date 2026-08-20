namespace UsingEnums.Examples;

internal static class SystemEnumType {
    internal static void Run() {
        GetEnumType();
        Console.WriteLine();

        GetEnumNameAndValue();
        Console.WriteLine();

        GetEnumValues();
    }

    private static void GetEnumType() {
        const EmployeeTypeEnum1 emp = EmployeeTypeEnum1.Manager;

        Console.WriteLine($"{nameof(EmployeeTypeEnum1)} uses a {Enum.GetUnderlyingType(emp.GetType())} for storage.");

        Console.WriteLine(
            $"{nameof(EmployeeTypeEnum1)} uses a {Enum.GetUnderlyingType(typeof(EmployeeTypeEnum1))} for storage.");
    }

    private static void GetEnumNameAndValue() {
        const EmployeeTypeEnum1 emp = EmployeeTypeEnum1.Manager;

        Console.WriteLine($"{nameof(emp)} is a {emp.ToString()}.");
        Console.WriteLine($"{emp.ToString()} = {(int)emp}");
    }

    private static void GetEnumValues() { }
}