using System.Collections;
using CustomEnumerator.Models;

namespace CustomEnumerator.Examples;

internal static class UsingIEnumeratorWithYield {
    internal static void Run() {
        var myGarage = new Garage2();

        IEnumerator carEnumerator = myGarage.GetEnumerator();
        using var carDisposable = carEnumerator as IDisposable;

        while (carEnumerator.MoveNext()) {
            if (carEnumerator.Current is not Car car) continue;

            Console.WriteLine($"{car.PetName} is going  {car.CurrentSpeed} MPH.");
        }
    }
}