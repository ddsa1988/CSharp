namespace TestingApp.Models;

public class Product {
    public string? Name { get; set; } = string.Empty;
    public decimal? Price { get; set; }

    public static Product[] GetProducts() {
        Product kayak = new Product() { Name = "Kayak", Price = 275M };
        Product lifeJacket = new Product() { Name = "Life Jacket", Price = 48.85M };

        return [kayak, lifeJacket];
    }
}