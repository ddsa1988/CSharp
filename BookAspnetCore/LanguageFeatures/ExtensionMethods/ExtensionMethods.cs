using System.Text.Json;
using LanguageFeatures.Models;

namespace LanguageFeatures.ExtensionMethods;

public static class ExtensionMethods {
    public static string ToJson(this Product product) {
        return JsonSerializer.Serialize(product);
    }

    public static Product? ToProduct(this string json) {
        return JsonSerializer.Deserialize<Product>(json);
    }

    public static decimal TotalPrice(this ShoppingCart shoppingCart) {
        decimal total = 0;

        if (shoppingCart.Products == null) return total;

        foreach (Product? product in shoppingCart.Products) {
            total += product?.Price ?? 0;
        }

        return total;
    }
}