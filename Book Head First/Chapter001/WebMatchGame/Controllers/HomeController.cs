using Microsoft.AspNetCore.Mvc;
using WebMatchGame.Models;

namespace WebMatchGame.Controllers;

public class HomeController : Controller {

    [HttpGet]
    public ViewResult Index() {
        return View("Index", Game.Emojis);
    }

    [HttpPost]
    public ViewResult Index(string emoji) {
        return View("Index", Game.Emojis);
    }
}
