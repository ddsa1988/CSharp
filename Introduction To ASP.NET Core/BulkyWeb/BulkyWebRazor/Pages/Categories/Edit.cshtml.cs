using BulkyWebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor.Pages.Categories;

[BindProperties]
public class Edit : PageModel {
    private readonly AppDbContext db;
    public Category? Category { get; set; }

    public Edit(AppDbContext db) {
        this.db = db;
    }

    public void OnGet(int? id) {
        if (id != null && id != 0) {
            Category = db.Categories.Find(id);
            // Category? category = db.Categories.FirstOrDefault(cat => cat.Id == id);
            // Category? category = db.Categories.Where(cat => cat.Id == id).FirstOrDefault();
        }
    }

    public IActionResult OnPost() {
        if (!ModelState.IsValid || Category == null) {
            return Page();
        }

        db.Categories.Update(Category);
        db.SaveChanges();

        TempData["success"] = "Category updated successfully";

        return RedirectToPage("Index");
    }
}