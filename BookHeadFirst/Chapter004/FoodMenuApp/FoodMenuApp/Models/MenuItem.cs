using System;

namespace FoodMenuApp.Models;

public class MenuItem {
    private readonly Random _random = new();

    public string[] Proteins = ["Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu"];

    public string[] Condiments =
        ["yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing"];

    public string[] Breads = ["rye", "white", "wheat", "pumpernickel", "a roll"];

    public string Description { get; private set; } = string.Empty;
    public string Price { get; private set; } = string.Empty;

    public void Generate() {
        string randomProtein = Proteins[_random.Next(Proteins.Length)];
        string randomCondiment = Condiments[_random.Next(Condiments.Length)];
        string randomBread = Breads[_random.Next(Breads.Length)];

        Description = $"{randomProtein} with {randomCondiment} on {randomBread}";

        decimal bucks = _random.Next(2, 5);
        decimal cents = _random.Next(1, 98);
        decimal price = bucks + (cents * 0.01m);
        Price = price.ToString("C");
    }
}