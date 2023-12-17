using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models;

public class Category {
    [Key] public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    [DisplayName("Category Name")]
    public string Name { get; set; } = "";

    [Range(1, 100, ErrorMessage = "Display Order must be between 1-100.")]
    [DisplayName("Display Order")]
    public int DisplayOrder { get; set; }

    public Category() { }

    public Category(int id, string name, int displayOrder) {
        Id = id;
        Name = name;
        DisplayOrder = displayOrder;
    }

    public override string ToString() {
        return $"Id = {Id} Name = {Name} Display order = {DisplayOrder}";
    }
}