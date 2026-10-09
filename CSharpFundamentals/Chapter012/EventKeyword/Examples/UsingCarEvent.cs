using EventKeyword.Models;

namespace EventKeyword.Examples;

internal static class UsingCarEvent {
    public static void Run() {
        var car1 = new CarClass1("SlugBug", 100, 10);

        car1.AboutToBlow += CarAboutToBlow;
        car1.AboutToBlow += CarIsAlmostDoomed;

        car1.Exploded += CarExploded;

        for (int i = 0; i < 6; i++) {
            car1.Accelerate(20);
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