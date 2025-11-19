// using Microsoft.AspNetCore.Mvc;
// using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller {
    public async Task<ViewResult> Index() {
        // Product[] products = Product.GetProducts();
        //
        // IEnumerable<string> productsDescription =
        //     products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price:C2}");
        //
        // return View(productsDescription);

        // long length = await MyAsyncMethods.GetPageLength("https://apress.com");
        //
        // return View(new[] { $"Length: {length}" });

        var output = new List<string>();
        string[] urls = ["https://apress.com", "https://microsoft.com", "https://amazon.com"];

        await foreach (long length in MyAsyncMethods.GetPageLengths(output, urls)) {
            output.Add($"Page length: {length}");
        }

        return View(output);
    }
}