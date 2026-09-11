using CustomInterfaces.Interfaces;
using CustomInterfaces.Models;

namespace CustomInterfaces.Examples;

internal static class DefaultImplementations {
    internal static void Run() {
        var sq = new Square("Square 1") { NumberOfSides = 4, SideLength = 4 };

        sq.Draw();

        Console.WriteLine(
            $"{sq.Name} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter of {((IRegularPointy)sq).Perimeter}");
    }
}