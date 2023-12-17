namespace BulkyWebRazor.Models;

public class Category {
    public int Id { get; set; }

    public string Name { get; set; } = "";

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