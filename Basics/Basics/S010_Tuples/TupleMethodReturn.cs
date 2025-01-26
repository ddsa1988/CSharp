namespace Basics.S010_Tuples;

public static class TupleMethodReturn {
    public static void UserMain() {
        (string first, string middle, string last) name = SplitName();

        Console.WriteLine(name);
        Console.WriteLine(name.first);
        Console.WriteLine(name.middle);
        Console.WriteLine(name.last);
    }

    private static (string first, string middle, string last) SplitName() {
        return ("Diego", "Santos", "Alexandre");
    }
}