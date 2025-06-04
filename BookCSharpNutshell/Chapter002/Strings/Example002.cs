namespace Chapter002.Strings;

public static class Example002 {
    public static void Run() {
        // Escape sequences express characters that cannot be expressed or interpreted literally.
        // An escape sequence is a backslash followed by a character with a special meaning.

        const char singleQuote = '\'';
        const char backSlash = '\\';
        const char nullChar = '\0';
        const char alert = '\a';
        const char backspace = '\b';
        const char formFeed = '\f';
        const char newLine = '\n';
        const char carriageReturn = '\r';
        const char horizontalTab = '\t';
        const char verticalTab = '\v';

        Console.WriteLine("{0} = {1}", nameof(singleQuote), singleQuote);
        Console.WriteLine("{0} = {1}", nameof(backSlash), backSlash);
        Console.WriteLine("{0} = {1}", nameof(nullChar), nullChar);
        Console.WriteLine("{0} = {1}", nameof(alert), alert);
        Console.WriteLine("{0} = {1}", nameof(backspace), backspace);
        Console.WriteLine("{0} = {1}", nameof(formFeed), formFeed);
        Console.WriteLine("{0} = {1}", nameof(newLine), newLine);
        Console.WriteLine("{0} = {1}", nameof(carriageReturn), carriageReturn);
        Console.WriteLine("{0} = {1}", nameof(horizontalTab), horizontalTab);
        Console.WriteLine("{0} = {1}", nameof(verticalTab), verticalTab);
    }
}