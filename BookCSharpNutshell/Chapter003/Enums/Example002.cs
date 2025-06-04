namespace Chapter003.Enums;

public static class Example002 {
    public static void Run() {
        // You can specify an explicit underlying value for each enum member.

        Console.WriteLine("{0} = {1}", BorderSide.Left, (int)BorderSide.Left);
        Console.WriteLine("{0} = {1}", BorderSide.Right, (int)BorderSide.Right);
        Console.WriteLine("{0} = {1}", BorderSide.Top, (int)BorderSide.Top);
        Console.WriteLine("{0} = {1}", BorderSide.Bottom, (int)BorderSide.Bottom);
    }

    private enum BorderSide {
        Left = 5,
        Right,
        Top = 10,
        Bottom
    }
}