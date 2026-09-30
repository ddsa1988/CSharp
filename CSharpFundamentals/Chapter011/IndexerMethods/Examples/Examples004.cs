using IndexerMethods.Models;

namespace IndexerMethods.Examples;

internal static class Example004 {
    internal static void Run() {
        var arr = new CollectionIndexerMultDim();

        arr[0, 0] = 10;
        arr[0, 1] = 20;
        arr[1, 0] = 30;
        arr[1, 1] = 40;
        arr[1, 2] = 50;
        arr[1, 3] = 60;

        arr.Print();
    }
}