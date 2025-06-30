namespace Chapter006.Strings;

public static class Example006 {
    public static void Run() {
        // Manipulating strings

        const string text = "This is a text.";
        const string msg = " This is a message. ";

        string textFirstWord = text.Substring(0, 4);
        string textMiddleWord = text.Substring(5, 4);
        string textLastWord = text.Substring(10);

        string textInserted = text.Insert(10, "beautiful ");
        string textReplaced = text.Replace("text", "message");
        string textRemoved = text.Remove(9, 5);

        string textWithPadLeft = text.PadLeft(20, '*');
        string textWithPadRight = text.PadRight(20, '*');

        string msgWithTrimStart = msg.TrimStart();
        string msgWithTrimEnd = msg.TrimEnd();
        string msgWithTrim = msg.Trim();

        Console.WriteLine(textFirstWord);
        Console.WriteLine(textMiddleWord);
        Console.WriteLine(textLastWord);
        Console.WriteLine(textInserted);
        Console.WriteLine(textReplaced);
        Console.WriteLine(textRemoved);
        Console.WriteLine(textWithPadLeft);
        Console.WriteLine(textWithPadRight);
        Console.WriteLine("*" + msgWithTrimStart + "*");
        Console.WriteLine("*" + msgWithTrimEnd + "*");
        Console.WriteLine("*" + msgWithTrim + "*");
    }
}