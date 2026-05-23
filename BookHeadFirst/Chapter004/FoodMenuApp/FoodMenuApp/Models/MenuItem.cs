using System;

namespace FoodMenuApp.Models;

public class MenuItems {
    private readonly Random _random = new();

    private readonly string[] _proteins = ["Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu"];

    private readonly string[] _condiments =
        ["yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing"];

    private readonly string[] _breads = ["rye", "white", "wheat", "pumpernickel", "a roll"];

    public string Description { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;

    public void Generate() {
        string randomProtein = _proteins[_random.Next(_proteins.Length)];
        string randomCondiment = _condiments[_random.Next(_condiments.Length)];
        string randomBread = _breads[_random.Next(_breads.Length)];

        Description = $"{randomProtein} with {randomCondiment} on {randomBread}";

        decimal bucks = _random.Next(2, 5);
        decimal cents = _random.Next(1, 98);
        decimal price = bucks + (cents * 0.01m);
        Price = price.ToString("C");
    }
}