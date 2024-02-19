namespace CSharpBasics.Chapter01;

public class ValueTypes {
    /*
     Value types are: numeric, char, bool, struct and enum types.
     Assigning a value type always copy the instance.
     Value types are storage in the stack.
    */

    public static void MyMain() {
        Point p1 = new Point { X = 10, Y = 20 };
        Point p2 = p1;

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine();

        p1.X = 22;
        p2.Y = 41;

        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }

    private struct Point {
        public int X;
        public int Y;

        public override string ToString() {
            return $"X = {X}, Y = {Y}";
        }
    }
}