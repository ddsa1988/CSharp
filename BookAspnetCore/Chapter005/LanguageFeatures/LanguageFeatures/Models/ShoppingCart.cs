using System.Collections;

namespace LanguageFeatures.Models;

public class ShoppingCart : IEnumerable<Product?>, IProductSelection {
    private readonly List<Product?> _products = [];

    public ShoppingCart(params Product[] products) {
        _products.AddRange(products);
    }

    public IEnumerable<Product?> Products => _products;

    public IEnumerator<Product?> GetEnumerator() {
        return Products.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}