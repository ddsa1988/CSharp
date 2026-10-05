using ExtensionMethods.MyExtensionsMethods;

namespace ExtensionMethods.Examples;

internal static class InvokingExtensionMethods {
    public static void Run() {
        {
            const int myInt = -123456789;

            myInt.DisplayDefiningAssembly();

            Console.WriteLine(myInt.ReverseDigits());
        }

        Console.WriteLine();

        {
            // System.Array implements IEnumerable!
            string[] data = [
                "Wow", "this", "is", "sort", "of", "annoying",
                "but", "in", "a", "weird", "way", "fun!"
            ];

            data.PrintDataAndBeep();

            Console.WriteLine();

            // List<T> implements IEnumerable!
            List<int> myInts = [10, 15, 20];
            myInts.PrintDataAndBeep();
        }
    }
}