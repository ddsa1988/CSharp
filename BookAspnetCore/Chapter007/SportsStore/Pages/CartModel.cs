using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportsStore.Infrastructure;
using SportsStore.Models;

namespace SportsStore.Pages;

public class CartModel : PageModel {
    private IStoreRepository _repository;
    public Models.Cart? Cart { get; set; }
    public string ReturnUrl { get; set; } = "/";

    public CartModel(IStoreRepository repository) {
        _repository = repository;
    }

    public void OnGet(string? returnUrl) {
        ReturnUrl = returnUrl ?? "/";
        Cart = HttpContext.Session.GetJson<Models.Cart>("cart") ?? new Models.Cart();
    }

    public IActionResult OnPost(long productId, string returnUrl) {
        Product? product = _repository.Products.FirstOrDefault(p => p.ProductId == productId);

        if (product == null) return RedirectToPage(new { returnUrl });
        Cart = HttpContext.Session.GetJson<Models.Cart>("cart") ?? new Models.Cart();
        Cart.AddItem(product, 1);
        HttpContext.Session.SetJson("cart", Cart);

        return RedirectToPage(new { returnUrl });
    }
}