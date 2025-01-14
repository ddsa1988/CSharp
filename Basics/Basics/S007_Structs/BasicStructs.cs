using Basics.S007_Structs.Models;

namespace Basics.S007_Structs;

public static class BasicStructs {
    public static void UserMain() {
        var p1 = new Point();
        var p2 = new Point(10, 20);

        p1.Display();
        p2.Display();

        p1.X = 275;
        p1.Y = 512;

        p2.Increment();

        Console.WriteLine();

        p1.Display();
        p2.Display();
    }
}