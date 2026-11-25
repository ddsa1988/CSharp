using System.Collections;
using LanguageIntegratedQuery.Models;

namespace LanguageIntegratedQuery.Examples;

internal static class LinqOverNonGenericCollections {
    public static void Run() {
        ArrayList myCars = [
            new Car() { PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
            new Car() { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
            new Car() { PetName = "Mary", Color = "Black", Speed = 55, Make = "VW" },
            new Car() { PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
            new Car() { PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" },
            100,
            "Diego Alexander",
            250f
        ];

        foreach (object obj in myCars) {
            Console.WriteLine(obj);
        }

        Console.WriteLine();

        IEnumerable<Car> myCarsEnumerable = myCars.OfType<Car>();

        // List<Car> myFastCars =
        //     (from car in myCarsEnumerable
        //         where car.Speed > 55
        //         select car).ToList();

        List<Car> myFastCars = myCarsEnumerable.Where(car => car.Speed > 55).ToList();

        foreach (Car car in myFastCars) {
            Console.WriteLine(car);
        }
    }
}