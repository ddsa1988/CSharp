namespace Inheritance.Models;

public class Egg {
    public double Size { get; private set; }
    public string Color { get; private set; }

    public Egg(double size, string color) {
        Size = size;
        Color = color;
    }

    public string Description => $"A {Size:0.0}cm {Color} egg.";
}