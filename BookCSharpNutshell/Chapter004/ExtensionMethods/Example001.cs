namespace Chapter004.ExtensionMethods;

public static class Example001 {
    public static void Run() {
        /*
            Extension methods allow an existing type to be extended with new methods without
            altering the definition of the original type. An extension method is a static method
            of a static class, where the 'this' modifier is applied to the first parameter.
            The type of the first parameter will be the type that is extended.
         */

        const string name1 = "Diego";
        const string name2 = "diego";
        const int number1 = 10;
        const int number2 = 13;

        Console.WriteLine(name1.IsCapitalized());
        Console.WriteLine(name2.IsCapitalized());
        
        Console.WriteLine(number1.IsPrime());
        Console.WriteLine(number2.IsPrime());
    }
}

internal static class StringHelper {
    public static bool IsCapitalized(this string str) {
        if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str)) return false;

        return char.IsUpper(str[0]);
    }
}

internal static class IntegerHelper {
    public static bool IsPrime(this int number) {
        return number % 2 == 0;
    }
}