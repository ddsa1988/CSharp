using System.Globalization;

namespace Section017_Delegates.Services; 

public class Product {
    private string name = "";
    private float price;

    public Product(string name, float price) {
        Name = name;
        Price = price;
    }
    
    public string Name {
        get { return name; }
        set { name = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) ? "" : value; }
    }

    public float Price {
        get { return price; }
        set { price = value > 0 ? value : 0; }
    }

    public override string ToString() {
        return "Name: " + Name +
               ", Price: $" + Price.ToString("F2", CultureInfo.InvariantCulture);
    }
}