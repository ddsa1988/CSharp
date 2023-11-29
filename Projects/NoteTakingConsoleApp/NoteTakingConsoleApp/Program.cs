using NoteTakingConsoleApp.Entities;

namespace NoteTakingConsoleApp;

public class Program {
    public static void Main(string[] args) {
        char separator = Path.AltDirectorySeparatorChar;

        string sourcePath = @$"..{separator}..{separator}..{separator}Files{separator}Text.txt";
        Console.WriteLine(Path.Exists(sourcePath));

        string text = File.ReadAllText(sourcePath);
        Console.WriteLine(text + "\n");

        Note n1 = new Note("test1");
        Note n2 = new Note("test2");
        Note n3 = new Note("test3");

        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);

    }
}