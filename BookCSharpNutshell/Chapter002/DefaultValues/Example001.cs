using System.Text;

namespace Chapter002.DefaultValues;

public static class Example001 {
    public static void UserMain() {
        Console.WriteLine("The default values for the predefined types are: \n");
        Console.WriteLine("Reference types = null");
        Console.WriteLine("Numeric and enum types = 0");
        Console.WriteLine("char type = '\\0'");
        Console.WriteLine("bool type = false");
    }
}