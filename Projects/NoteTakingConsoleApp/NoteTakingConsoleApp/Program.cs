using NoteTakingConsoleApp.Entities;

namespace NoteTakingConsoleApp;

public class Program {
    public static void Main(string[] args) {
        char separator = Path.AltDirectorySeparatorChar;

        string sourcePath = @$"..{separator}..{separator}..{separator}Files{separator}Text.txt";
        Console.WriteLine(Path.Exists(sourcePath));

        string text = File.ReadAllText(sourcePath);
        Console.WriteLine(text + "\n");

        NoteBook noteBook = new NoteBook();
        noteBook.AddNote("Test1");
        noteBook.AddNote("Test2");
        noteBook.AddNote("Test3");
        noteBook.AddNote("Test4");

        Console.WriteLine(noteBook);

    }
}