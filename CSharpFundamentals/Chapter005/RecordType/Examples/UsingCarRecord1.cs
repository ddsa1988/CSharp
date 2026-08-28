using RecordType.Models;

namespace RecordType.Examples;

internal static class UsingCarRecord1 {
    internal static void Run() {
        var myCar = new CarRecord1("Honda", "Civic", "Gray");

        Console.WriteLine(myCar);
        Console.WriteLine(myCar.Make);
        Console.WriteLine(myCar.Model);
        Console.WriteLine(myCar.Color);
    }
}