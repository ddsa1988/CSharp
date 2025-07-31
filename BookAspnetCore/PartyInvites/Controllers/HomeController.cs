using Microsoft.AspNetCore.Mvc;
using PartyInvites.Mapping;
using PartyInvites.Models;

namespace PartyInvites.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        return View();
    }

    [HttpGet]
    public ViewResult RsvpForm() {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse) {
        string responseJson = guestResponse.GuestResponseToJson();

        Repository.Repository.WriteGuestResponse(responseJson);

        return View("Thanks", guestResponse);
    }

    public ViewResult ListResponses() {
        IEnumerable<GuestResponse> guestResponses = Repository.Repository.GetGuestResponses();

        return View(guestResponses.Where(response => response.WillAttend == true));
    }
}