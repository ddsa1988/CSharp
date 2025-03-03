namespace LanguageFeatures.Models;

public class Product {
    public string Name { get; set; }
    public double? Price { get; set; }

    public static Product[] GetProducts() {
        Product kayak = new Product() { Name = "Kayak", Price = 275 };
        Product lifeJacket = new Product() { Name = "Lifejacket", Price = 48.95 };

        return new Product[] { kayak, lifeJacket, null };
    }
}