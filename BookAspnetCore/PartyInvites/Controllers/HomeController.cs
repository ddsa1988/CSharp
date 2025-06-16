using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using PartyInvites.Service;

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
    public ViewResult RsvpForm(Response newResponse) {
        const string thanksView = "Thanks";

        if (!ModelState.IsValid) return View();

        IEnumerable<Response> responses = DatabaseService.ReadAll();

        Response? existingResponse = responses.FirstOrDefault(response => response.Equals(newResponse));

        if (existingResponse != null) return View();

        DatabaseService.Write(newResponse);

        return View(thanksView, newResponse);
    }

    public ViewResult ListResponses() {
        IEnumerable<Response> responses = DatabaseService.ReadAll();

        return View(responses.Where(response => response.WillAttend == true));
    }
}