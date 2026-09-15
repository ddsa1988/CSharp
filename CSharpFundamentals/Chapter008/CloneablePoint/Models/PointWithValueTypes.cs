namespace CloneablePoint.Models;

internal class PointWithValueTypes : ICloneable {
    public int X { get; set; }
    public int Y { get; set; }

    public PointWithValueTypes(int xPos, int yPos) {
        X = xPos;
        Y = yPos;
    }

    public PointWithValueTypes() : this(0, 0) { }

    public override string ToString() {
        return $"Point {{ {nameof(X)} = {X}, {nameof(Y)} = {Y} }}";
    }

    // Return a copy of the current object
    public object Clone() {
        // return new PointWithValueTypes(X, Y);
        return MemberwiseClone();
    }
}