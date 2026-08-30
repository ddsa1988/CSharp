using RecordType.Models;

namespace RecordType.Examples;

internal static class DeconstructingRecords {
    internal static void Run() {
        var myCar = new CarRecord2("Honda", "Civic", "Gray");

        {
            myCar.Deconstruct(out string make, out string model, out string color);
            Console.WriteLine($"Make: {make},  Model: {model},  Color: {color}");
        }

        Console.WriteLine();

        {
            (string make, string model, string color) = myCar;
            Console.WriteLine($"Make: {make},  Model: {model},  Color: {color}");
        }
    }
}