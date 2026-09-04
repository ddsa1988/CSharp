using SuperParentClassObject.Models;

namespace SuperParentClassObject.Examples;

internal static class UsingPerson1 {
    public static void Run() {
        Console.WriteLine("Using Inherited Members of System.Object\n");

        var p1 = new Person1();
        var p2 = new Person1();

        Console.WriteLine("ToString: " + p1.ToString());
        Console.WriteLine("GetHashCode: " + p1.GetHashCode());
        Console.WriteLine("Type: " + p1.GetType());
        Console.WriteLine("Equals : " + p1.Equals(p2));
    }
}