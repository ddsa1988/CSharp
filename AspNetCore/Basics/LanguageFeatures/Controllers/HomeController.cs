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

    //public ViewResult Index() {
    //    var cart = new ShoppingCart() { Products = Product.GetProducts() };

    //    double cartTotal = cart.TotalPrice();

    //    return View("Index", new string[] { $"Total: {cartTotal:C2}" });
    //}

    //public async Task<ViewResult> Index() {
    //    long? length = await MyAsyncMethods.GetPageLength();

    //    return View(new string[] { $"Length: {length}" });
    //}

    public async Task<ViewResult> Index() {
        var output = new List<string>();

        await foreach (long? len in MyAsyncMethods.GetPageLengths(output,
        "apress.com", "microsoft.com", "amazon.com")) {
            output.Add($"Page length: {len}");
        }

        return View(output);
    }
}