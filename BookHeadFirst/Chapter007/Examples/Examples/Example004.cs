using Examples.Models;

namespace Examples;

public static class Example004 {
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
                case ISwimmer swimmer:
                    swimmer.Swim();
                    break;
                case IPackHunter hunter:
                    hunter.HuntInPack();
                    break;
            }

            // if (animal is ISwimmer swimmer) {
            //     swimmer.Swim();
            // }
            //
            // if (animal is IPackHunter hunter) {
            //    hunter.HuntInPack();
            // }

            // if (typeof(ISwimmer).IsAssignableFrom(animal.GetType())) {
            //     var swimmer = (ISwimmer)animal;
            //     swimmer.Swim();
            // }
            //
            // if (typeof(IPackHunter).IsAssignableFrom(animal.GetType())) {
            //     var hunter = (IPackHunter)animal;
            //     hunter.HuntInPack();
            // }

            Console.WriteLine();
        }
    }
}