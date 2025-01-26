namespace Basics.S010_Tuples;

public static class TupleDiscard {
    public static void UserMain() {
        (string firstName, _, string lastName) = ("Diego", "Santos", "Alexandre");

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
    }
}