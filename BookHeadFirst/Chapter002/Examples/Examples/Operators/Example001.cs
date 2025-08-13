namespace Examples.Operators;

public static class Example001 {
    public static void Run() {
        int width = 3;
        width++;

        const int height = 2 + 4;
        int area = width * height;
        Console.WriteLine(area);

        string result = "The area";
        result += " is " + area;
        Console.WriteLine(result);

        const bool truthValue = true;
        Console.WriteLine(truthValue);
    }
}