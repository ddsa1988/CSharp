using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using PartyInvites.Service;

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
    public ViewResult RsvpForm(Response response) {
        const string view = "RsvpForm";
        
        Console.WriteLine(response);
        
        ManageDatabase.Write(response);
        
        return View(view);
    }
}