using BulkyWebRazor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor.Pages.Categories;

public class Index : PageModel {
    private readonly AppDbContext db;
    public List<Category> Categories { get; set; }

    public Index(AppDbContext db) {
        this.db = db;
    }

    public void OnGet() {
        Categories = db.Categories.OrderBy(category => category.DisplayOrder).ToList();
    }
}