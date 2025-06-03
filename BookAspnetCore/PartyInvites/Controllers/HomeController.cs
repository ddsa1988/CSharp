using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers;

public class HomeController : Controller {
    public IActionResult Index() {
        const string view = "Index";
        const string msg = "Party Invites Application";

        return View(view, msg);
    }
}