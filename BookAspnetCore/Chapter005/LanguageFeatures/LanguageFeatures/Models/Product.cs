namespace LanguageFeatures.Models;

public class Product {
    public required string Name { get; init; }
    public required decimal Price { get; init; }

    public static Product[] GetProducts() {
        Product kayak = new() { Name = "Kayak", Price = 275M };
        Product lifeJacket = new() { Name = "Life Jacket", Price = 48.95M };

        return [kayak, lifeJacket];
    }

    public override string ToString() {
        return $"Product [{nameof(Name)}: {Name}, {nameof(Price)}: {Price}]";
    }
}