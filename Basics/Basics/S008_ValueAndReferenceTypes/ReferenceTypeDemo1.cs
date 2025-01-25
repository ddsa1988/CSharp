using Basics.S008_ValueAndReferenceTypes.Models;

namespace Basics.S008_ValueAndReferenceTypes;

public static class ReferenceTypeDemo1 {
    public static void UserMain() {
        var p1 = new PointClass { X = 10, Y = 20 };
        PointClass p2 = p1;

        p2.X = 50;
        p2.Y = 70;

        Console.WriteLine("p1 = " + p1);
        Console.WriteLine("p2 = " + p2);
    }
}