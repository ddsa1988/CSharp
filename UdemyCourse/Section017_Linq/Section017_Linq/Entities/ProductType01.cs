using System.Globalization;

namespace Section017_Linq.Entities;

public class ProductType01 {
    private string name = "";
    private float price;

    public ProductType01(string name, float price) {
        Name = name;
        Price = price;
    }
    
    public string Name {
        get => name;
        set => name = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) ? "" : value;
    }

    public float Price {
        get => price;
        set => price = value > 0 ? value : 0;
    }

    public override string ToString() {
        return "Name: " + Name +
               " Price: $" + Price.ToString("F2", CultureInfo.InvariantCulture);
    }
}