namespace Inheritance.Models;

public class Egg {
    private double Size { get; }
    private string Color { get; }

    public Egg(double size, string color) {
        Size = size;
        Color = color;
    }

    public string Description => $"A {Size:0.0}cm {Color} egg.";
}