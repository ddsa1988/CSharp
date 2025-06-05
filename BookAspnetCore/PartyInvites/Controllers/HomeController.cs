using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        const string view = "Index";
        return View(view);
    }

    [HttpGet]
    public ViewResult RsvpForm() {
        const string view = "RsvpForm";
        return View(view);
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse) {
        const string view = "RsvpForm";
        Console.WriteLine(guestResponse);
        return View(view);
    }
}