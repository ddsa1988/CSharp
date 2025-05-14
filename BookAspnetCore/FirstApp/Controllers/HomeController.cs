using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers;

public class HomeController : Controller {
    public string Index() {
        return "Hello, I'm Diego alexandre.";
    }
}