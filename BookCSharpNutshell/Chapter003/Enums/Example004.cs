namespace Chapter003.Enums;

public static class Example004 {
    public static void Run() {
        // Flag enums are combined enum members. To prevent ambiguities, members of a combinable
        // enum require explicitly assigned values, typically in powers of two.
        // To work with combined enum values, you use bitwise operators such as | and &.

        const BorderSides leftRight = BorderSides.Left | BorderSides.Right;
        const BorderSides topBottom = BorderSides.Top & BorderSides.Bottom;

        Console.WriteLine("{0} = {1}", nameof(leftRight), (int)leftRight);
        Console.WriteLine("{0} = {1}", nameof(topBottom), (int)topBottom);
    }

    [Flags]
    private enum BorderSides {
        None = 0, // 0
        Left = 1, // 1
        Right = 1 << 1, // 2
        Top = 1 << 2, // 4
        Bottom = 1 << 3 // 8
    }
}