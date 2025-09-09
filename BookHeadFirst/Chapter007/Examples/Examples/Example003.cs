using Examples.Models;

namespace Examples;

public static class Example003 {
    public static void Run() {
        Animal[] animals = [
            new Hippo(),
            new Wolf(false),
            new Wolf(true),
            new Hippo(),
            new Wolf(true),
        ];

        foreach (Animal animal in animals) {
            animal.MakeNoise();

            switch (animal) {
                case Hippo hippo:
                    hippo.Swim();
                    break;
                case Wolf wolf:
                    wolf.HuntInPack();
                    break;
            }

            Console.WriteLine();

            // animal.MakeNoise();
            //
            // if (typeof(Hippo).IsInstanceOfType(animal)) {
            //     var hippo = (Hippo)animal;
            //     hippo.Swim();
            // }
            //
            // if (typeof(Wolf).IsInstanceOfType(animal)) {
            //     var wolf = (Wolf)animal;
            //     wolf.HuntInPack();
            // }
            //
            // Console.WriteLine();

            // animal.MakeNoise();
            //
            // if (animal is Hippo hippo) {
            //     hippo.Swim();
            //     continue;
            // }
            //
            // if (animal is Wolf wolf) {
            //     wolf.HuntInPack();
            // }
            //
            // Console.WriteLine();
        }
    }
}