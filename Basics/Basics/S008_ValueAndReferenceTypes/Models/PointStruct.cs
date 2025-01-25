namespace Basics.S008_ValueAndReferenceTypes.Models;

public struct PointStruct {
    public double X { get; set; }
    public double Y { get; set; }

    public override string ToString() {
        return $"(X = {X}, Y = {Y})";
    }
}