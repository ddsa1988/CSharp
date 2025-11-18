namespace LanguageFeatures.Models;

public static class MyExtensionMethods {
    public static decimal GetTotalPrices(this ShoppingCart shoppingCart) {
        return shoppingCart.Products.OfType<Product>().Sum(product => product.Price);

        // decimal total = 0;
        //
        // if (shoppingCart.Products == null) return total;
        //
        // foreach (Product? product in shoppingCart.Products) {
        //     if (product == null) continue;
        //
        //     total += product.Price;
        // }
    }

    public static IEnumerable<Product?> FilterByPrice(this IEnumerable<Product?> products, decimal minimalPrice) {
        return products.OfType<Product>().Where(product => product.Price >= minimalPrice);

        // foreach (Product? product in products) {
        //     if (product == null || product.Price < minimalPrice) continue;
        //
        //     yield return product;
        // }
    }

    public static IEnumerable<Product?> Filter(this IEnumerable<Product?> products, Func<Product?, bool> selector) {
        return products.Where(selector);

        // foreach (Product? product in products) {
        //     if (!selector(product)) continue;
        //
        //     yield return product;
        // }
    }
}