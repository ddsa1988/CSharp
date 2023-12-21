using BulkyWebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor.Pages.Categories;

[BindProperties]
public class Delete : PageModel {
    private readonly AppDbContext db;
    public Category? Category { get; set; }

    public Delete(AppDbContext db) {
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
        if (Category?.Id == null || Category?.Id == 0) {
            return Page();
        }

        Category? category = db.Categories.Find(Category?.Id);

        if (category == null) {
            return Page();
        }

        db.Categories.Remove(category);
        db.SaveChanges();

        TempData["success"] = "Category deleted successfully";

        return RedirectToPage("Index");
    }
}