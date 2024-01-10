using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        Dictionary<string, int> people = new Dictionary<string, int>();
        people.Add("Diego", 35);
        people.Add("Amanda", 30);
        people.Add("Rodrigo", 29);

        return View("MyView", people);
    }

    public IActionResult Privacy() {
        return View();
    }
}