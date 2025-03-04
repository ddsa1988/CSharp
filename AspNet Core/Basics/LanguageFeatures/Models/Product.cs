namespace LanguageFeatures.Models;

public class Product {
    public string Name { get; set; } = string.Empty;
    public double? Price { get; set; }

    public static Product?[] GetProducts() {
        var kayak = new Product() { Name = "Kayak", Price = 275 };
        var lifeJacket = new Product() { Name = "Life jacket", Price = 48.95 };

        return [kayak, lifeJacket, null];
    }
}