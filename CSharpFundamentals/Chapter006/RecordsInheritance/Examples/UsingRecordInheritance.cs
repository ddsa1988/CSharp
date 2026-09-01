using RecordsInheritance.Models;

namespace RecordsInheritance.Examples;

internal static class UsingRecordInheritance {
    internal static void Run() {
        Console.WriteLine("Record type inheritance!\n");

        var myCar = new CarRecord("Honda", "Pilot", "Blue");
        var myVan = new MiniVanRecord("Honda", "Pilot", "Blue", 10);

        Console.WriteLine(myCar);
        Console.WriteLine(myVan);
        Console.WriteLine($"Checking if {nameof(MiniVanRecord)} is-a {nameof(CarRecord)}: {myVan is CarRecord}");
    }
}