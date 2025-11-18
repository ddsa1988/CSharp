namespace LanguageFeatures.Models;

public interface IProductSelection {
    IEnumerable<Product?> Products { get; }

    IEnumerable<string> Names => Products.OfType<Product>().Select(product => product.Name);
}