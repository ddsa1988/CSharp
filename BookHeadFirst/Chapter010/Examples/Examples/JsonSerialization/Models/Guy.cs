namespace Examples.JsonSerialization.Models;

public class Guy {
    public required string Name { get; init; }
    public required HairStyle Hair { get; init; }
    public required Outfit Clothes { get; init; }
    public override string ToString() => $"{Name} with {Hair} wearing {Clothes}";
}

public class Outfit {
    public required string Top { get; init; }
    public required string Bottom { get; init; }
    public override string ToString() => $"{Top} and {Bottom}";
}

public class HairStyle {
    public HairColor Color { get; init; }
    public float Length { get; init; }
    public override string ToString() => $"{Length:0.0} inch {Color} hair";
}

public enum HairColor {
    Auburn,
    Black,
    Blonde,
    Blue,
    Brown,
    Gray,
    Platinum,
    Purple,
    Red,
    White,
}