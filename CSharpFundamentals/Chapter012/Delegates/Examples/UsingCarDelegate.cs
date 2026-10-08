using Delegates.Models;

namespace Delegates.Examples;

internal static class UsingCarDelegate {
    public static void Run() {
        var car1 = new Car("SlugBug", 100, 10);

        car1.RegisterWithCarEngine(OnCarEngineEvent1);
        car1.RegisterWithCarEngine(OnCarEngineEvent2);

        Console.WriteLine("***** Speeding up *****");
        for (int i = 0; i < 6; i++) {
            car1.Accelerate(20);
        }
    }

    private static void OnCarEngineEvent1(string msg) {
        Console.WriteLine("\n***** Message From Car Object *****");
        Console.WriteLine("=> " + msg);
        Console.WriteLine(new string('*', 35));
    }

    private static void OnCarEngineEvent2(string msg) {
        Console.WriteLine("=> " + msg.ToUpper());
    }
}