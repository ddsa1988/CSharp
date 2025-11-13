namespace PartyInvites.Utilities;

public static class RepositoryFile {
    private const string FolderName = "Files";
    private const string FileName = "GuestResponses.json";
    private static readonly string DirectoryPath = AppContext.BaseDirectory + FolderName;
    private static readonly string FilePath = Path.Combine(DirectoryPath, FileName);


    public static void Write(string content) {
        if (string.IsNullOrEmpty(content.Trim())) return;

        if (!Directory.Exists(DirectoryPath)) {
            Directory.CreateDirectory(DirectoryPath);
        }

        if (File.Exists(FilePath)) {
            File.Delete(FilePath);
        }

        try {
            File.WriteAllText(FilePath, content);
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }

    public static string Read() {
        if (!File.Exists(FilePath)) return string.Empty;

        string content = string.Empty;

        try {
            content = File.ReadAllText(FilePath);
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }

        return content;
    }
}