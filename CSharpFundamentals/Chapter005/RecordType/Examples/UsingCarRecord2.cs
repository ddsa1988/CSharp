using RecordType.Models;

namespace RecordType.Examples;

internal static class UsingCarRecord2 {
    internal static void Run() {
        var myCar = new CarRecord2("Honda", "Civic", "Gray");

        Console.WriteLine(myCar);
        Console.WriteLine(myCar.Make);
        Console.WriteLine(myCar.Model);
        Console.WriteLine(myCar.Color);
    }
}