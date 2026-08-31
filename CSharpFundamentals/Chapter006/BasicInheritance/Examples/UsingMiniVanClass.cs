using BasicInheritance.Models;

namespace BasicInheritance.Examples;

internal static class UsingMiniVanClass {
    public static void Run() {
        var myVan = new MiniVan() { Speed = 50 };

        Console.WriteLine(myVan);
    }
}