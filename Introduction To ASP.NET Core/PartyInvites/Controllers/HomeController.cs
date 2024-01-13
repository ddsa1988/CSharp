using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers;

public class HomeController : Controller {
    public IActionResult Index() {
        return View();
    }

    [HttpGet]
    public ViewResult RsvpForm() {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse) {
        Console.WriteLine(guestResponse.Name);
        Console.WriteLine(guestResponse.Email);
        Console.WriteLine(guestResponse.Phone);
        Console.WriteLine(guestResponse.WillAttend);
        
        return View();
    }
}