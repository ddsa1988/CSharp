using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        string[] strings = ["C#", "Language", "Features"];

        return View(strings);
    }
}