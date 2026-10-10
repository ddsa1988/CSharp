using EventKeyword.Models;

namespace EventKeyword.Examples;

internal static class UsingCarEvent2 {
    public static void Run() {
        var car = new CarClass2("SlugBug", 100, 10);

        car.AboutToBlow += CarAboutToBlow;

        car.Exploded += CarExploded;

        for (int i = 0; i < 6; i++) {
            car.Accelerate(20);
        }
    }

    private static void CarAboutToBlow(object sender, CarEventArgs e) {
        if (sender is not CarClass2 car) return;

        Console.WriteLine($"Critical message from {car.Name}: {e.Msg}");
    }

    private static void CarExploded(object sender, CarEventArgs e) {
        if (sender is not CarClass2 car) return;

        Console.WriteLine($"Critical message from {car.Name}: {e.Msg}");
    }
}