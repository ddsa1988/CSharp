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
    public async Task<ViewResult> RsvpForm(GuestResponse guestResponse) {
        if (!ModelState.IsValid) return View();

        string? responseJson = guestResponse.GuestResponseToJson();

        if (responseJson == null) return View();

        await Repository.Repository.WriteGuestResponse(responseJson);

        return View("Thanks", guestResponse);
    }

    public async Task<ViewResult> ListResponses() {
        IEnumerable<GuestResponse> guestResponses = await Repository.Repository.GetGuestResponses();

        return View(guestResponses.Where(response => response.WillAttend == true));
    }
}