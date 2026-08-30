using RecordType.Models;

namespace RecordType.Examples;

internal static class RecordsEquality {
    internal static void Run() {
        var myCar1 = new CarRecord1("Honda", "Civic", "Gray");
        var myCar2 = new CarRecord1("Honda", "Civic", "Gray");
        var myCar3 = new CarRecord1("Honda", "Civic", "Blue");

        Console.WriteLine(myCar1.Equals(myCar2));
        Console.WriteLine(myCar1.Equals(myCar3));
    }
}