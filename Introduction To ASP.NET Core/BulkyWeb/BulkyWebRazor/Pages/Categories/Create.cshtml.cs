using BulkyWebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor.Pages.Categories;

[BindProperties]
public class Create : PageModel {
    private readonly AppDbContext db;
    public Category Category { get; set; }

    public Create(AppDbContext db) {
        this.db = db;
    }

    public void OnGet() { }

    public IActionResult OnPost() {
        if (!ModelState.IsValid) {
            return Page();
        }

        db.Categories.Add(Category);
        db.SaveChanges();

        TempData["success"] = "Category created successfully";

        return RedirectToPage("Index");
    }
}