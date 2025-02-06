using Basics.S011_ObjectOrientedProgramming.Models;

namespace Basics.S011_ObjectOrientedProgramming;

public class StaticClassDemo {
    public static void UserMain() {
        TimeUtilClass.PrintTime();
        TimeUtilClass.PrintDate();

        Console.WriteLine("Age: " + TimeUtilClass.GetAge(new DateTime(1988, 1, 22)));
    }
}