namespace Basics.S008_ValueAndReferenceTypes.Models;

public struct Rectangle {
    public readonly ShapeInfo RectInfo;

    public int RectTop, RectLeft, RectBottom, RectRight;

    public Rectangle(string info, int rectTop, int rectLeft, int rectBottom, int rectRight) {
        RectInfo = new ShapeInfo(info);
        RectTop = rectTop;
        RectLeft = rectLeft;
        RectBottom = rectBottom;
        RectRight = rectRight;
    }

    public override string ToString() {
        return
            $"Info = {RectInfo.InfoString}, Top = {RectTop}, Bottom = {RectBottom}, Left = {RectLeft}, Right = {RectRight} ";
    }
}