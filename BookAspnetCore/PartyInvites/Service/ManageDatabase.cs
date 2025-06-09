namespace PartyInvites.Service;

public static class ManageDatabase {
    private const string FolderName = "Database";
    private const string FileName = "Database.txt";
    private static readonly char SepChar = Path.DirectorySeparatorChar;
    private static readonly string DatabasePath = $"{FolderName}{SepChar}{FileName}";

    public static void PrintDatabasePath() {
        Console.WriteLine(Path.GetFullPath(DatabasePath));
        Console.WriteLine(File.Exists(DatabasePath));
    }
}