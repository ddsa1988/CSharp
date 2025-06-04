using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        const string view = "Index";

        GuestResponse[] responses = [
            new("Diego", "diego@outlook.com", "984211", true),
            new("Amanda", "amanda@outlook.com", "74585", false),
            new("Amora", "amora@outlook.com", "123548", true),
            new("Ameixa", "ameixa@outlook.com", "452183", true)
        ];
        return View(view, responses);
    }

    public ViewResult RsvpForm() {
        const string view = "RsvpForm";

        return View(view);
    }
}