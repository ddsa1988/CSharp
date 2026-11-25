using LanguageIntegratedQuery.Models;

namespace LanguageIntegratedQuery.Examples;

internal static class LinqOverCollections {
    public static void Run() {
        List<Car> myCars = [
            new() { PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
            new() { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
            new() { PetName = "Mary", Color = "Black", Speed = 55, Make = "VW" },
            new() { PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
            new() { PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" }
        ];

        // List<Car> fastCars =
        //     (from car in myCars
        //         where car.Speed > 55
        //         select car).ToList();

        List<Car> fastCars = myCars.Where(car => car.Speed > 55).ToList();

        foreach (Car car in fastCars) {
            Console.WriteLine(car);
        }

        Console.WriteLine();

        // List<Car> fastCarsBmw =
        //     (from car in myCars
        //         where car.Speed > 90 && car.Make.Equals("bmw", StringComparison.InvariantCultureIgnoreCase)
        //         select car).ToList();

        List<Car> fastCarsBmw = myCars.Where(car =>
            car.Speed > 90 && car.Make.Equals("bmw", StringComparison.InvariantCultureIgnoreCase)).ToList();

        foreach (Car car in fastCarsBmw) {
            Console.WriteLine(car);
        }
    }
}