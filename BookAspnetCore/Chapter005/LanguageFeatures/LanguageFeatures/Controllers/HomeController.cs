// using Microsoft.AspNetCore.Mvc;
// using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        Product[] products = Product.GetProducts();

        IEnumerable<string> productsDescription =
            products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price:C2}");

        return View(productsDescription);
    }
}