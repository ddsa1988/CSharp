using NoteTakingConsoleApp.Entities;

namespace NoteTakingConsoleApp;

public class Program {
    public static void Main(string[] args) {
        char separator = Path.AltDirectorySeparatorChar;

        string sourcePath = @$"..{separator}..{separator}..{separator}Files{separator}DataBase.txt";

        Notebook notebook = new Notebook(sourcePath);
        Console.WriteLine(notebook);
    }
}