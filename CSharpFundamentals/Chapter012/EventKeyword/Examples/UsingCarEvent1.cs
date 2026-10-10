using EventKeyword.Models;

namespace EventKeyword.Examples;

internal static class UsingCarEvent1 {
    public static void Run() {
        var car = new CarClass1("SlugBug", 100, 10);

        car.AboutToBlow += CarAboutToBlow;
        car.AboutToBlow += CarIsAlmostDoomed;

        car.Exploded += CarExploded;

        for (int i = 0; i < 6; i++) {
            car.Accelerate(20);
        }
    }

    private static void CarAboutToBlow(string msg) {
        Console.WriteLine(msg);
    }

    private static void CarIsAlmostDoomed(string msg) {
        Console.WriteLine("=> Critical message from car: " + msg);
    }

    private static void CarExploded(string msg) {
        Console.WriteLine(msg);
    }
}