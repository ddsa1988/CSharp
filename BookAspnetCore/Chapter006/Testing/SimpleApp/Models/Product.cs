namespace SimpleApp.Models;

public class Product {
    public required string Name { get; set; }
    public required decimal Price { get; set; }

    public static Product[] GetProducts() {
        var kayak = new Product { Name = "Kayak", Price = 275M };
        var lifeJacket = new Product { Name = "Life Jacket", Price = 48.95M };

        return [kayak, lifeJacket];
    }

    public string Description() {
        return $"{nameof(Name)}: {Name}, {nameof(Price)}: {Price:C2}";
    }

    public override string ToString() {
        return $"Product [{nameof(Name)}: {Name}, {nameof(Price)}: {Price}]";
    }
}