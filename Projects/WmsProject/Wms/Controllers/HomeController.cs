using Microsoft.AspNetCore.Mvc;

namespace Wms.Controllers;

public class HomeController : Controller {
    public IActionResult Index() {
        return View();
    }
}