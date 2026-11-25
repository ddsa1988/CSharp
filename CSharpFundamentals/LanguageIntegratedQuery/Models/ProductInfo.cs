namespace LanguageIntegratedQuery.Models;

internal class ProductInfo {
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int NumberInStock { get; set; }

    public override string ToString() {
        return
            $"Product Info [{nameof(Name)} = {Name}, {nameof(Description)} = {Description}, {nameof(NumberInStock)} = {NumberInStock}]";
    }
}