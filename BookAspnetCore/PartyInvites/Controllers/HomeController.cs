using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        return View();
    }

    public ViewResult RsvpForm() {
        return View();
    }
}