using System.Collections;
using CustomEnumerator.Models;

namespace CustomEnumerator.Examples;

internal static class GuardClausesWithLocalFunctions {
    internal static void Run() {
        {
            Console.WriteLine("Without local function!");

            var garage = new Garage3();
            IEnumerator carEnumerator = garage.GetEnumerator();
            using var carDisposable = carEnumerator as IDisposable;

            Console.WriteLine("Starting...:");

            try {
                while (carEnumerator.MoveNext()) {
                    if (carEnumerator.Current is not Car car) continue;

                    Console.WriteLine($"{car.PetName} is going  {car.CurrentSpeed} MPH.");
                }
            }
            catch (Exception e) {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }

        Console.WriteLine();

        {
            var garage = new Garage3();

            Console.WriteLine("With local function!");

            try {
                IEnumerator carEnumerator = garage.GetEnumerator1();
                using var carDisposable = carEnumerator as IDisposable;

                Console.WriteLine("Starting...");

                while (carEnumerator.MoveNext()) {
                    if (carEnumerator.Current is not Car car) continue;

                    Console.WriteLine($"{car.PetName} is going  {car.CurrentSpeed} MPH.");
                }
            }
            catch (Exception e) {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}