namespace Examples.Lists.Models;

public class Shoe {
    private readonly Style _style;
    private readonly Color _color;

    public Shoe(Style style, Color color) {
        _style = style;
        _color = color;
    }

    public string Description => $"A {_color} {_style}";

    public override string ToString() {
        return $"Shoe[color = {_color}, style = {_style}]";
    }
}