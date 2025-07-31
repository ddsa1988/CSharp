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
        var response = new GuestResponse() { Name = "Diego", Email = "email", Phone = "9999", WillAttend = true };
        string responseJson = response.GuestResponseToJson();

        Console.WriteLine("Write file");
        Repository.Repository.WriteGuestResponse(responseJson);

        Console.WriteLine("\nRead file");

        IEnumerable<GuestResponse> guestResponses = Repository.Repository.GetGuestResponses();
        Console.WriteLine(guestResponses);

        return View();
    }
}