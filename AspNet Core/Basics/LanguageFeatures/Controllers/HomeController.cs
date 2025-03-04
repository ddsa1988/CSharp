using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller {
    // public ViewResult Index() {
    //     Product?[] products = Product.GetProducts();
    //
    //     IEnumerable<string?> names = products.Where(p => p?.Name != null).Select(p => p?.Name);
    //
    //     return View("Index", names);
    // }

    public ViewResult Index() {
        var cart = new ShoppingCart() { Products = Product.GetProducts() };
    
        double cartTotal = cart.TotalPrice();
    
        return View("Index", new string[] { $"Total: {cartTotal:C2}" });
    }
}