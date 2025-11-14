using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using PartyInvites.Utilities;

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
        if (!ModelState.IsValid) return View();

        Repository.AddGuestResponse(guestResponse);
        string json = Repository.GuestResponses.ToJson();
        RepositoryFile.Write(json);

        return View("Thanks", guestResponse);
    }

    [HttpGet]
    public ViewResult ListResponses() {
        return View(Repository.GuestResponses.Where(response => response.WillAttend == true));
    }
}