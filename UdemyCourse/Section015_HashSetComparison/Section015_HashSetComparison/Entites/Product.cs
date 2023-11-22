namespace Section015_HashSetComparison; 

public class Product {

    public string Name { get; set; }
    public float Price { get; set; }

    public Product(string name, float price) {
        Name = name;
        Price = price;
    }

    public override bool Equals(object? obj) {
        if (obj is not Product) return false;
        
        Product? other = obj as Product;

        return Name.Equals(other?.Name) && Price.Equals(other.Price);
    }

    public override int GetHashCode() {
        return Name.GetHashCode() + Price.GetHashCode();
    }
}