using Basics.S008_ValueAndReferenceTypes.Models;

namespace Basics.S008_ValueAndReferenceTypes;

public static class ReferenceTypeDemo2 {
    public static void UserMain() {
        var rect1 = new Rectangle("First rectangle", 10, 10, 50, 50);
        Rectangle rect2 = rect1;

        rect2.RectInfo.InfoString = "This is a new info";
        rect2.RectTop = 111;
        rect2.RectBottom = 222;
        rect2.RectLeft = 333;
        rect2.RectRight = 444;

        Console.WriteLine(rect1);
        Console.WriteLine(rect2);
    }
}