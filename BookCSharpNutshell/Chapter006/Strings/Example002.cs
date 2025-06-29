namespace Chapter006.Strings;

public static class Example002 {
    public static void Run() {
        // Constructing strings

        char[] chars = "Diego".ToCharArray();

        const string str1 = "Hello";
        const string str2 = "First line\r\nSecond line";
        const string str3 = @"\\server\FileShared\HelloWorld.cs";
        string str4 = new string(chars);

        Console.WriteLine(str1);
        Console.WriteLine(str2);
        Console.WriteLine(str3);
        Console.WriteLine(str4);
    }
}