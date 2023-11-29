using System.Globalization;

namespace Section017_Linq.Entities;

public class ProductType02 {
    private string name = "";
    private int id;
    private float price;
    public Category Category { get; set; }

    public ProductType02(string name, int id, float price, Category category) {
        Name = name;
        Id = id;
        Price = price;
        Category = category;
    }

    public string Name {
        get => name;
        set => name = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) ? "" : value;
    }

    public int Id {
        get => id;
        set => id = value > 0 ? value : 0;
    }

    public float Price {
        get => price;
        set => price = value > 0 ? value : 0;
    }

    public override string ToString() {
        return "Name: " + Name +
               ", Id: " + Id +
               ", Price: " + Price.ToString("F2", CultureInfo.InvariantCulture) +
               ", Category name: " + Category.Name +
               ", Tier: " + Category.Tier;
    }
}