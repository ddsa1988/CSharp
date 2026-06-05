using Interfaces.Models;

namespace Interfaces.Examples;

public static class UsingTheIsOperator {
    public static void Run() {
        IAnimal[] animals = [
            new Hippo(),
            new Wolf(false),
            new Wolf(true),
            new Hippo()
        ];


        foreach (IAnimal animal in animals) {
            animal.MakeNoise();

            if (animal is Hippo hippo) {
                hippo.Swim();
            }

            if (animal is Wolf wolf) {
                wolf.HuntInPack();
            }

            Console.WriteLine();
        }
    }
}