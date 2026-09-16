using ComparableCar.Models;
using ComparableCar.Utilities;

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
        Console.WriteLine();

        Array.Sort(myCars, new CarNameComparer());

        Console.WriteLine("Here is the ordered by name set of cars: ");
        Console.WriteLine(string.Join("\n", myCars));
        Console.WriteLine();

        // Sorting by static property made a bit cleaner
        Console.WriteLine("Here is the ordered by name set of cars (static property): ");
        Array.Sort(myCars, Car.SortByName);
        Console.WriteLine(string.Join("\n", myCars));
    }
}