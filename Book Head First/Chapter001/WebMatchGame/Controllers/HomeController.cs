using Microsoft.AspNetCore.Mvc;
using WebMatchGame.Models;

namespace WebMatchGame.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        return View("Index", SetUpGame.GetRandomEmojis());
    }
}
