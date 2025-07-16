namespace LanguageFeatures.Models;

public class Product {
    public required string Name { get; init; }
    public decimal? Price { get; init; }

    public override string ToString() {
        string obj = $"Product [Name = {Name}, Price = {Price:C2}]";

        return obj;
    }
}