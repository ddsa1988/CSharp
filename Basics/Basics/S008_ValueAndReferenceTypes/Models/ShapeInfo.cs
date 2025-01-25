namespace Basics.S008_ValueAndReferenceTypes.Models;

public class ShapeInfo {
    public ShapeInfo(string infoString) {
        InfoString = infoString;
    }

    public string InfoString { get; set; }

    public override string ToString() {
        return "Info: " + InfoString;
    }
}