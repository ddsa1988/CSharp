namespace ShoeStore.Models;

public class Shoe {
    public Style Style { get; private set; }
    public Color Color { get; private set; }

    public Shoe(Style style, Color color) {
        Style = style;
        Color = color;
    }

    public string Description() {
        return $"A {Color} {Style}";
    }

    public override string ToString() {
        return $"A {Color} {Style}";
    }
}