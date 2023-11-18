namespace Section014_Interface.Entities; 

public class Vehicle {
    
    private string model = "";

    public Vehicle(string model) {
        Model = model;
    }
    
    public string Model {
        get { return model; }
        set { model = string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) ? "" : value; }
    }

    public override string ToString() {
        return "Model: " + Model;
    }
}