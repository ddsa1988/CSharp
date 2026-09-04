using SuperParentClassObject.Models;

namespace SuperParentClassObject.Examples;

internal static class UsingPerson2 {
    public static void Run() {
        Console.WriteLine("Using Inherited Members of System.Object\n");

        var p1 = new Person2("Diego", "Alexander", 38);

        Console.WriteLine("ToString: " + p1.ToString());
        Console.WriteLine("GetHashCode: " + p1.GetHashCode());
        Console.WriteLine("Type: " + p1.GetType());
    }
}