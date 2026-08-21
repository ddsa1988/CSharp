namespace UsingEnums.Examples;

internal static class SystemEnumType {
    internal static void Run() {
        // GetEnumType();
        // Console.WriteLine();
        //
        // GetEnumNameAndValue();
        // Console.WriteLine();

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

    private static void GetEnumValues() {
        const EmployeeTypeEnum1 emp = EmployeeTypeEnum1.Contractor;
        const DayOfWeek day = DayOfWeek.Monday;
        const ConsoleColor cc = ConsoleColor.Gray;

        EvaluateEnum(emp);
        Console.WriteLine();

        EvaluateEnum(day);
        Console.WriteLine();

        EvaluateEnum(cc);

        return;

        static void EvaluateEnum(Enum e) {
            Console.WriteLine("=> Information about " + e.GetType().Name + ":\n");

            Console.WriteLine("Underlying storage type: " + Enum.GetUnderlyingType(e.GetType()));

            Array enumData = Enum.GetValues(e.GetType());

            Console.WriteLine($"This enum has {enumData.Length} members.");

            for (int i = 0; i < enumData.Length; i++) {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
            }
        }
    }
}