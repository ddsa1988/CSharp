using System.Globalization;

namespace Chapter006.Strings;

public static class Example011 {
    public static void Run() {
        // String order comparison

        const string msg1 = "Hello";
        const string msg2 = "hello";

        int result = string.Compare(msg1, msg2, false, CultureInfo.InvariantCulture);
        Console.WriteLine("string.Compare({0}, {1}, ignoreCase: {2}) => {3}", msg1, msg2, false, result);

        result = string.Compare(msg2, msg1, false, CultureInfo.InvariantCulture);
        Console.WriteLine("string.Compare({0}, {1}, ignoreCase: {2}) => {3}", msg2, msg1, false, result);

        result = string.Compare(msg1, msg2, true, CultureInfo.InvariantCulture);
        Console.WriteLine("string.Compare({0}, {1}, ignoreCase: {2}) => {3}", msg1, msg2, true, result);
    }
}