using System.Collections;
using CustomEnumerator.Models;

namespace CustomEnumerator.Examples;

internal static class UsingNamedIterator {
    internal static void Run() {
        var myGarage = new Garage4();

        IEnumerable cars = myGarage.GetTheCars(true);

        foreach (Car car in cars) {
            Console.WriteLine(car.PetName);
        }
    }
}