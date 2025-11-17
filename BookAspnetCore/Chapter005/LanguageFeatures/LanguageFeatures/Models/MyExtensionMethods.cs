namespace LanguageFeatures.Models;

public static class MyExtensionMethods {
    public static decimal GetTotalPrices(this ShoppingCart shoppingCart) {
        return shoppingCart.Products == null
            ? 0
            : shoppingCart.Products.OfType<Product>().Sum(product => product.Price);
        
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
}