namespace SimpleApp.Models;

public class Product {
    public required string Name { get; set; }
    public required decimal Price { get; set; }

    public string Description() {
        return $"{nameof(Name)}: {Name}, {nameof(Price)}: {Price:C2}";
    }

    public override string ToString() {
        return $"Product [{nameof(Name)}: {Name}, {nameof(Price)}: {Price}]";
    }
}