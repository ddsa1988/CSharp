using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers;

public class HomeController : Controller {
    public string Index() {
        return "Hello, I'm Diego alexandre.";
    }
}