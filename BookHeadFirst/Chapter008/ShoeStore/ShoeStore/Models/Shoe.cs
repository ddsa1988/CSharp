namespace ShoeStore.Models;

public class Shoe {
    private readonly Style _style;
    private readonly Color _color;

    public Shoe(Style style, Color color) {
        _style = style;
        _color = color;
    }

    public string Description() {
        return $"A {_color} {_style}";
    }

    public override string ToString() {
        return $"A {_color} {_style}";
    }
}