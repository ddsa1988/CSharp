using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;

namespace SimpleApp.Controllers;

public class HomeController : Controller {
    public IDataSource DataSource { get; set; } = new ProductDataSource();

    public IActionResult Index() {
        return View(DataSource.Products);
    }
}