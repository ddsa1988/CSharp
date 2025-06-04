namespace Chapter003.Enums;

public static class Example001 {
    public static void Run() {
        // An enum is a special value type that lets you specify a group of named numeric constants.

        const BorderSide topSide = BorderSide.Top;

        Console.WriteLine("{0} => {1} == {2}\n", nameof(topSide), topSide, BorderSide.Top);

        Console.WriteLine("{0} = {1}", BorderSide.Left, (int)BorderSide.Left);
        Console.WriteLine("{0} = {1}", BorderSide.Right, (int)BorderSide.Right);
        Console.WriteLine("{0} = {1}", BorderSide.Top, (int)BorderSide.Top);
        Console.WriteLine("{0} = {1}", BorderSide.Bottom, (int)BorderSide.Bottom);
    }

    private enum BorderSide {
        Left,
        Right,
        Top,
        Bottom
    }
}