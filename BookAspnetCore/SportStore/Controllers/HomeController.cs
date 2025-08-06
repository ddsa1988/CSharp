using Microsoft.AspNetCore.Mvc;
using SportStore.Models;

namespace SportStore.Controllers;

public class HomeController : Controller {
    private readonly IStoreRepository _storeRepository;

    public HomeController(IStoreRepository storeRepository) {
        _storeRepository = storeRepository;
    }

    public IActionResult Index() {
        return View(_storeRepository.Products);
    }
}