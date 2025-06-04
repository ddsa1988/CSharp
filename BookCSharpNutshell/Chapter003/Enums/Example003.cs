namespace Chapter003.Enums;

public static class Example003 {
    public static void Run() {
        // You can convert an enum instance to and from its underlying integral value with an explicit cast.

        const int bottomValue = (int)BorderSide.Bottom;
        const BorderSide bottomBorder = (BorderSide)bottomValue;

        Console.WriteLine("{0} = {1}", nameof(bottomValue), bottomValue);
        Console.WriteLine("{0} = {1}", nameof(bottomBorder), bottomBorder);
    }

    private enum BorderSide {
        Left,
        Right,
        Top,
        Bottom
    }
}