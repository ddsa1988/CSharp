namespace LanguageFeatures.Models;

public static class Products {
    public static Product?[] GetProducts() {
        return [
            new Product() { Name = "Kayak", Price = 275M },
            new Product() { Name = "Life jacket", Price = 48.95M },
            null
        ];
    }
}