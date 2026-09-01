using RecordsInheritance.Models;

namespace RecordsInheritance.Examples;

internal static class UsingPositionalRecordInheritance {
    internal static void Run() {
        Console.WriteLine("Record type inheritance!\n");

        var myCar = new PositionalCarRecord("Honda", "Pilot", "Blue");
        var myVan = new PositionalMiniVanRecord("Honda", "Pilot", "Blue", 10);

        Console.WriteLine(myCar);
        Console.WriteLine(myVan);
        Console.WriteLine(
            $"Checking if {nameof(PositionalMiniVanRecord)} is-a {nameof(PositionalCarRecord)}: {myVan is PositionalCarRecord}");
    }
}