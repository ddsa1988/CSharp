using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        const string greeting = "Hello. Today is ";
        string date = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        string msg = greeting + date + ".";
        
        return View("MyView", msg);
    }
}