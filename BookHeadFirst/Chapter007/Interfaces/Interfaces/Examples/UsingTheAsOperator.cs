using Interfaces.Models;

namespace Interfaces.Examples;

public static class UsingTheAsOperator {
    public static void Run() {
        IAnimal[] animals = [
            new Hippo(),
            new Wolf(false),
            new Wolf(true),
            new Hippo()
        ];


        foreach (IAnimal animal in animals) {
            animal.MakeNoise();

            var hippo = animal as Hippo;
            hippo?.Swim();

            var wolf = animal as Wolf;
            wolf?.HuntInPack();

            Console.WriteLine();
        }
    }
}