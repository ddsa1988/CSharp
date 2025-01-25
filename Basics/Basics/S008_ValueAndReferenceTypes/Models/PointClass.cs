namespace Basics.S008_ValueAndReferenceTypes.Models;

public class PointClass {
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString() {
        return $"(X = {X}, Y = {Y})";
    }
}