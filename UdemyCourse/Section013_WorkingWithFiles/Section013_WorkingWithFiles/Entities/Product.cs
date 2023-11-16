namespace Section013_WorkingWithFiles.Entities; 

public class Product {

    private string name = "";
    private float price;
    private int quantity;

    public Product() { }

    public Product(string name, float price, int quantity) {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    
    public string Name {
        get => name; 
        set => name = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) ? "" : value; 
    }

    public float Price {
        get => price;
        set => price = value > 0 ? value : 0;
    }
    
    public int Quantity {
        get => quantity;
        set => quantity = value > 0 ? value : 0;
    }

    public float Total() {
        return Price * Quantity;
    }
    
    public override string ToString() {
        return $"Name: {Name} \nPrice: ${Price:F2} \nQuantity: {Quantity}";
    }
}