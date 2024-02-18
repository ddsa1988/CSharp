using System.Threading.Channels;

namespace CSharpBasics.Chapter01;

public class ReferenceTypes {
    /*Reference types are: class, array, string, delegate and interface types.
     Assigning a reference type copy the reference not the object instance.
     The reference to the object instance is storage in the stack and the object instance is storage in the heap.
     The garbage collector destroy the object instance if no reference to it's instance is found.
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

    private class Point {
        public int X;
        public int Y;

        public override string ToString() {
            return $"X = {X}, Y = {Y}";
        }
    }
}