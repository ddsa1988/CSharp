using Microsoft.AspNetCore.Mvc;

namespace WebMatchGame.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        return View();
    }
}
