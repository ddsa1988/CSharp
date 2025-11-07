namespace Examples.ExtensionMethods;

public static class Example001 {
    public static void Run() {
        Console.WriteLine("diego".ToTitleCase());
        Console.WriteLine("DIEGO".ToTitleCase());
        Console.WriteLine("dIEGO".ToTitleCase());
    }
}

public static class MyExtensionMethods {
    public static string ToTitleCase(this string input) {
        if (string.IsNullOrEmpty(input.Trim())) return input;

        return char.ToUpper(input[0]) + input.Substring(1).ToLower();
    }
}