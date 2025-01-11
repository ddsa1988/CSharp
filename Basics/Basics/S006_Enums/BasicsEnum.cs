namespace Basics.S006_Enums;

public static class BasicsEnum {
    public static void UserMain() {
        Console.WriteLine("{0} => {1}", EmployeeEnum1.Manager, (int)EmployeeEnum1.Manager);
        Console.WriteLine("{0} => {1}", EmployeeEnum1.Grunt, (int)EmployeeEnum1.Grunt);
        Console.WriteLine("{0} => {1}", EmployeeEnum1.Contractor, (int)EmployeeEnum1.Contractor);
        Console.WriteLine("{0} => {1}", EmployeeEnum1.VicePresident, (int)EmployeeEnum1.VicePresident);

        Console.WriteLine();

        Console.WriteLine("{0} => {1}", EmployeeEnum2.Manager, (int)EmployeeEnum2.Manager);
        Console.WriteLine("{0} => {1}", EmployeeEnum2.Grunt, (int)EmployeeEnum2.Grunt);
        Console.WriteLine("{0} => {1}", EmployeeEnum2.Contractor, (int)EmployeeEnum2.Contractor);
        Console.WriteLine("{0} => {1}", EmployeeEnum2.VicePresident, (int)EmployeeEnum2.VicePresident);

        Console.WriteLine();

        Console.WriteLine("{0} => {1}", EmployeeEnum3.Manager, (byte)EmployeeEnum3.Manager);
        Console.WriteLine("{0} => {1}", EmployeeEnum3.Grunt, (byte)EmployeeEnum3.Grunt);
        Console.WriteLine("{0} => {1}", EmployeeEnum3.Contractor, (byte)EmployeeEnum3.Contractor);
        Console.WriteLine("{0} => {1}", EmployeeEnum3.VicePresident, (byte)EmployeeEnum3.VicePresident);
    }

    private enum EmployeeEnum1 {
        Manager,
        Grunt,
        Contractor,
        VicePresident
    }

    private enum EmployeeEnum2 {
        Manager = 200,
        Grunt,
        Contractor,
        VicePresident
    }

    private enum EmployeeEnum3 : byte {
        Manager = 100,
        Grunt = 5,
        Contractor = 75,
        VicePresident = 32
    }
}