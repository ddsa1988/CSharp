using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers;

public class CategoryController : Controller {
    private readonly AppDbContext db;

    public CategoryController(AppDbContext db) {
        this.db = db;
    }

    public IActionResult Index() {
        List<Category> categories = db.Categories.ToList();
        return View(categories);
    }

    public IActionResult Create() {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category category) {
        if (!ModelState.IsValid) return View();

        db.Categories.Add(category);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
}