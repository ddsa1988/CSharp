using System.Globalization;

namespace Section017_LinqExercise.Entities;

public class Product {
    private float price;
    public string Name { get; set; } = "";

    public Product(string name, float price) {
        Name = name;
        Price = price;
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