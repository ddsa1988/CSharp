namespace Basics.S005_Methods;

public static class MethodParameterRef {
    public static void UserMain() {
        {
            int x = 10;
            int y = 20;

            Console.WriteLine("Before swap: x => {0}, y => {1}", x, y);
            Swap<int>(ref x, ref y);
            Console.WriteLine("After swap: x => {0}, y => {1}", x, y);
        }

        Console.WriteLine();

        {
            string x = "Diego";
            string y = "Amanda";

            Console.WriteLine("Before swap: x => {0}, y => {1}", x, y);
            Swap<string>(ref x, ref y);
            Console.WriteLine("After swap: x => {0}, y => {1}", x, y);
        }

    }

    private static void Swap<T>(ref T a, ref T b) {
        (a, b) = (b, a);
    }
}