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
    public ViewResult RsvpForm(GuestResponse response) {
        if (ModelState.IsValid) {
            Repository.AddResponse(response);
            return View("Thanks", response);
        } else {
            return View();
        }
    }

    [HttpGet]
    public ViewResult ListResponses() {
        IEnumerable<GuestResponse> responses = Repository.Responses.Where(response => response?.WillAttend == true);

        return View(responses);
    }
}