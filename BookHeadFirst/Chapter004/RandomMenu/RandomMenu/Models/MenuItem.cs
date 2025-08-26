using System;

namespace RandomMenu.Models;

public static class MenuItem {
    private static readonly Random Random = new Random();
    private static readonly string[] Proteins = ["Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu"];

    private static readonly string[] Condiments =
        ["yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing"];

    private static readonly string[] Breads = ["rye", "white", "wheat", "pumpernickel", "a roll"];
    public static string Description = string.Empty;
    public static string Price = string.Empty;

    public static void Generate() {
        string randomProtein = Proteins[Random.Next(0, Proteins.Length)];
        string randomCondiment = Condiments[Random.Next(0, Condiments.Length)];
        string randomBread = Breads[Random.Next(0, Breads.Length)];
        Description = randomProtein + " with " + randomCondiment + " on " + randomBread;

        decimal bucks = Random.Next(2, 5);
        decimal cents = Random.Next(1, 98);
        decimal price = bucks + (cents * 0.01M);
        Price = price.ToString("C2");
    }
}