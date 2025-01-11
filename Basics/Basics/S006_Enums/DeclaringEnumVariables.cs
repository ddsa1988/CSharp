namespace Basics.S006_Enums;

public static class DeclaringEnumVariables {
    public static void UserMain() {
        var e = EmployeeEnum.Manager;
        Console.WriteLine(AskForBonus(e) + "\n");

        e = EmployeeEnum.Grunt;
        Console.WriteLine(AskForBonus(e) + "\n");

        e = EmployeeEnum.Contractor;
        Console.WriteLine(AskForBonus(e) + "\n");

        e = EmployeeEnum.VicePresident;
        Console.WriteLine(AskForBonus(e) + "\n");
    }

    private static string AskForBonus(EmployeeEnum employee) {
        string msg = employee switch {
            EmployeeEnum.Manager => "Manager asked for bonus.",
            EmployeeEnum.Grunt => "Grunt asked dor bonus.",
            EmployeeEnum.Contractor => "Contractor asked for bonus",
            EmployeeEnum.VicePresident => "Vice president asked for bonus",
            _ => ""
        };

        return msg;
    }

    // private static string AskForBonus(EmployeeEnum employee) {
    //     string msg = "";
    //
    //     switch (employee) {
    //         case EmployeeEnum.Manager:
    //             msg = "Manager asked for bonus.";
    //             break;
    //         case EmployeeEnum.Grunt:
    //             msg = "Grunt asked for bonus.";
    //             break;
    //         case EmployeeEnum.Contractor:
    //             msg = "Contractor asked for bonus.";
    //             break;
    //         case EmployeeEnum.VicePresident:
    //             msg = "Vice president asked for bonus.";
    //             break;
    //         default:
    //             msg = "";
    //             break;
    //     }
    //
    //     return msg;
    // }
}