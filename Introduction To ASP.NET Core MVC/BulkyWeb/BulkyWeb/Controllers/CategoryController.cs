using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers;

public class CategoryController : Controller {
    private readonly AppDbContext db;

    public CategoryController(AppDbContext db) {
        this.db = db;
    }

    public IActionResult Index() {
        List<Category> categories = db.Categories.OrderBy(category => category.DisplayOrder).ToList();
        return View(categories);
    }

    [HttpGet]
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

    [HttpGet]
    public IActionResult Edit(int? id) {
        if (id == null || id == 0) {
            return NotFound();
        }

        Category? category = db.Categories.Find(id);
        // Category? category = db.Categories.FirstOrDefault(cat => cat.Id == id);
        // Category? category = db.Categories.Where(cat => cat.Id == id).FirstOrDefault();

        if (category == null) {
            return NotFound();
        }

        return View(category);
    }

    [HttpPost]
    public IActionResult Edit(Category category) {
        if (!ModelState.IsValid) return View();

        db.Categories.Update(category);
        return RedirectToAction("Index");
    }
}