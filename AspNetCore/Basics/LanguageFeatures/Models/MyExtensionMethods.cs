namespace LanguageFeatures.Models;

public static class MyExtensionMethods {
    public static double TotalPrice(this ShoppingCart cartParam) {
        double total = 0;

        if (cartParam.Products == null) return total;

        foreach (Product? prod in cartParam.Products) {
            total += prod?.Price ?? 0;
        }

        return total;
    }
}