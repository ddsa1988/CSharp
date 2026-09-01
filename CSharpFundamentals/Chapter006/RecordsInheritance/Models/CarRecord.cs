namespace RecordsInheritance.Models;

internal record class CarRecord {
    public string Make { get; init; }
    public string Model { get; init; }
    public string Color { get; init; }

    public CarRecord(string make, string model, string color) {
        Make = make;
        Model = model;
        Color = color;
    }
}