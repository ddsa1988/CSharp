namespace Basics.S010_Tuples.Models;

public struct PointStruct {
    public double X { get; set; }
    public double Y { get; set; }

    public (double xPos, double yPos) Deconstruct() {
        return (X, Y);
    }

    public override string ToString() {
        return $"(X = {X}, Y = {Y})";
    }
}