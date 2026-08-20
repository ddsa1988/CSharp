namespace UsingEnums.Examples;

internal static class DeclaringEnumVariables {
    internal static void Run() {
        const EmployeeTypeEnum1 emp = EmployeeTypeEnum1.Contractor;

        AskForBonus(emp);
    }

    private static void AskForBonus(EmployeeTypeEnum1 employee) {
        switch (employee) {
            case EmployeeTypeEnum1.Manager:
                Console.WriteLine("How about stock options instead?");
                break;
            case EmployeeTypeEnum1.Grunt:
                Console.WriteLine("You have got to be kidding.");
                break;
            case EmployeeTypeEnum1.Contractor:
                Console.WriteLine("You already get enough cash...");
                break;
            case EmployeeTypeEnum1.VicePresident:
                Console.WriteLine("Very Good, Sir!");
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(employee), employee, null);
        }
    }
}