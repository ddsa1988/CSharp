using Microsoft.AspNetCore.Mvc;

namespace S002_PartyInvites.Controllers;
public class HomeController : Controller {
    public IActionResult Index() {
        return View();
    }

    public ViewResult RsvpForm() {
        return View();
    }
}
