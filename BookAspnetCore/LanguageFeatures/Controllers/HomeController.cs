using LanguageFeatures.ExtensionMethods;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        return View();
    }

    public ViewResult Example001() {
        IEnumerable<Product?> products = Products.GetProducts();
        return View("Example001", products);
    }

    public ViewResult Example002() {
        var shoppingCart = new ShoppingCart() { Products = Products.GetProducts() };
        decimal totalPrice = shoppingCart.TotalPrice();

        return View("Example002", (shoppingCart.Products, totalPrice));
    }
}