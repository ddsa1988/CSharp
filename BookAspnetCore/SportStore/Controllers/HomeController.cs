using Microsoft.AspNetCore.Mvc;
using SportStore.Models;

namespace SportStore.Controllers;

public class HomeController : Controller {
    private readonly IStoreRepository _storeRepository;
    private const int PageSize = 4;

    public HomeController(IStoreRepository storeRepository) {
        _storeRepository = storeRepository;
    }

    public ViewResult Index(int productPage) {
        return View(_storeRepository.Products
            .OrderBy(product => product.ProductId)
            .Skip((productPage - 1) * PageSize)
            .Take(PageSize));
    }
}