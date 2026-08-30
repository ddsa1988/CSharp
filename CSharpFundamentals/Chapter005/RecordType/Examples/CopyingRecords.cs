using RecordType.Models;

namespace RecordType.Examples;

internal static class CopyingRecords {
    internal static void Run() {
        var myCar1 = new CarRecord1("Honda", "Civic", "Gray");
        CarRecord1 myCar2 = myCar1 with { Model = "Odyssey", Color = "Blue" };

        Console.WriteLine(myCar1);
        Console.WriteLine(myCar2);
    }
}