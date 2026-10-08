namespace Delegates.Examples;

internal static class GenericDelegates {
    private delegate void MyGenericDelegate<T>(T arg);

    public static void Run() {
        {
            MyGenericDelegate<string> myDelegate = StringTarget;

            myDelegate("Hello");
        }

        Console.WriteLine();

        {
            MyGenericDelegate<int> myDelegate = IntTarget;

            myDelegate(200);
        }
    }

    private static void StringTarget(string arg) {
        Console.WriteLine($"{nameof(arg)} in uppercase is: {arg.ToUpper()}");
    }

    private static void IntTarget(int arg) {
        Console.WriteLine($"++{nameof(arg)} is: {++arg}");
    }
}