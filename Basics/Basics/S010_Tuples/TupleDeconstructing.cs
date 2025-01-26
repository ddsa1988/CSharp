using Basics.S010_Tuples.Models;

namespace Basics.S010_Tuples;

public static class TupleDeconstructing {
    public static void UserMain() {
        {
            var myTuple = (10, 20);

            (int x, int y) = myTuple;

            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        Console.WriteLine();

        {
            var p1 = new PointStruct { X = 50, Y = 70 };

            (double xPos, double yPos) pointValues = p1.Deconstruct();

            Console.WriteLine(pointValues.xPos);
            Console.WriteLine(pointValues.yPos);
        }
    }
}