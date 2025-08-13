using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers;

public class HomeController : Controller {
    private readonly IStoreRepository _storeRepository;
    private const int PageSize = 4;

    public HomeController(IStoreRepository storeRepository) {
        _storeRepository = storeRepository;
    }

    public ViewResult Index(string? category, int productPage = 1) {
        var productsListViewModel = new ProductsListViewModel() {
            Products = _storeRepository.Products
                .Where(product => product.Category == category)
                .OrderBy(product => product.ProductId)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo() {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = _storeRepository.Products.Count()
            },
            CurrentCategory = category
        };
        return View(productsListViewModel);
    }
}