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
}