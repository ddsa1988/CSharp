namespace Chapter002.Parameters;

public static class Example001 {
    public static void UserMain() {
        Console.WriteLine("Parameter modifier\t Passed by\t\t\t Variable must be defined assigned\n");
        Console.WriteLine("None\t\t\t Value\t\t\t\t Going in");
        Console.WriteLine("ref\t\t\t Reference\t\t\t Going in");
        Console.WriteLine("in\t\t\t Reference(read-only)\t\t Going in");
        Console.WriteLine("out\t\t\t Reference\t\t\t Going out");
    }
}