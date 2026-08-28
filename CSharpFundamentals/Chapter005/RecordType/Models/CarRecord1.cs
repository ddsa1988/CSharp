namespace RecordType.Models;

internal record class CarRecord1 {
    public string Make { get; init; }
    public string Model { get; init; }
    public string Color { get; init; }

    public CarRecord1(string make, string model, string color) {
        Make = make;
        Model = model;
        Color = color;
    }
}