using ComparableCar.Models;

namespace ComparableCar.Examples;

internal static class ComparingCars {
    internal static void Run() {
        Car[] myCars = [
            new("Rusty", 80, 1),
            new("Mary", 40, 240),
            new("Viper", 40, 34),
            new("Mel", 40, 4),
            new("Chuck", 40, 5)
        ];

        Console.WriteLine("Here is the unordered set of cars: ");
        Console.WriteLine(string.Join("\n", myCars));
        Console.WriteLine();

        Array.Sort(myCars);

        Console.WriteLine("Here is the ordered set of cars: ");
        Console.WriteLine(string.Join("\n", myCars));
    }
}