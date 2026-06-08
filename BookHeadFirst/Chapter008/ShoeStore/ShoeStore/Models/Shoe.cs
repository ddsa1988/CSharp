namespace ShoeStore.Models;

public class Shoe {
    private Style Style { get; }
    private Color Color { get; }

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