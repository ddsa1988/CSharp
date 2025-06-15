using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using PartyInvites.Service;

namespace PartyInvites.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        const string defaultView = "Index";

        return View(defaultView);
    }

    [HttpGet]
    public ViewResult RsvpForm() {
        const string defaultView = "RsvpForm";

        return View(defaultView);
    }

    [HttpPost]
    public ViewResult RsvpForm(Response newResponse) {
        const string defaultView = "RsvpForm";
        const string thanksView = "Thanks";

        IEnumerable<Response> responses = DatabaseService.ReadAll();

        Response? existingResponse = responses.FirstOrDefault(response => response.Equals(newResponse));

        if (existingResponse != null) {
            return View(defaultView);
        }

        DatabaseService.Write(newResponse);

        return View(thanksView, newResponse);
    }

    public ViewResult ListResponses() {
        const string defaultView = "ListResponses";

        IEnumerable<Response> responses = DatabaseService.ReadAll();

        return View(defaultView, responses.Where(response => response.WillAttend == true));
    }
}