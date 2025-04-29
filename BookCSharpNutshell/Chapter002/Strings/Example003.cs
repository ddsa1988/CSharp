namespace Chapter002.Strings;

public static class Example003 {
    public static void UserMain() {
        // The \u (or \x) escape sequence lets you specify any Unicode character via its
        // four-digit hexadecimal code.

        const char copyrightSymbol = '\u00A9';
        const char omegaSymbol = '\u03A9';
        const char newLine = '\u000A';

        Console.WriteLine("{0} = {1}", nameof(copyrightSymbol), copyrightSymbol);
        Console.WriteLine("{0} = {1}", nameof(omegaSymbol), omegaSymbol);
        Console.WriteLine("{0} = {1}", nameof(newLine), newLine);
    }
}