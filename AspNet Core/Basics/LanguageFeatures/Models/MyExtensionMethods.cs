namespace LanguageFeatures.Models;

public static class MyExtensionMethods {
    public static double TotalPrice(this ShoppingCart cartParam) {
        double totalPrice = 0;

        if (cartParam == null) return totalPrice;

        foreach (Product? prod in cartParam.Products) {
            totalPrice += prod?.Price ?? 0;
        }

        return totalPrice;
    }
}