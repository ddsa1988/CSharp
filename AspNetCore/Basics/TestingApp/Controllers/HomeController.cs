using Microsoft.AspNetCore.Mvc;
using TestingApp.Models;

namespace TestingApp.Controllers;

public class HomeController : Controller {
    public ViewResult Index() {
        return View(Product.GetProducts());
    }
}