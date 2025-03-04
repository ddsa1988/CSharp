using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        Product?[] products = Product.GetProducts();

        IEnumerable<string?> names = products.Where(p => p?.Name != null).Select(p => p?.Name);
        
        return View(names);
    }
}