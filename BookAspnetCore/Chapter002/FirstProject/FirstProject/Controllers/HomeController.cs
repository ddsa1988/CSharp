using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers;

public class HomeController : Controller {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) {
        _logger = logger;
    }

    public ViewResult Index() {
        int hour = DateTime.Now.Hour;
        string viewModel = hour < 12 ? "Good morning" : "Good afternoon";

        return View("MyView", viewModel);
    }
}