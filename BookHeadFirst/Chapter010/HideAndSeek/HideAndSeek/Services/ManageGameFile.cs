using HideAndSeek.Models;

namespace HideAndSeek.Services;

public static class ManageGameFile {
    public static void Write(string content) {
        const string folderName = "Files";
        const string fileName = "GameStatus.txt";
        string folderPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(folderPath, fileName);

        if (!Directory.Exists(folderPath)) {
            Directory.CreateDirectory(folderPath);
        }

        if (File.Exists(filePath)) {
            File.Delete(filePath);
        }

        using var sw = new StreamWriter(filePath);
        sw.Write(content);
    }

    public static string Read() {
        const string folderName = "Files";
        const string fileName = "GameStatus.txt";
        string folderPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(folderPath, fileName);
        string content = string.Empty;

        if (!File.Exists(filePath)) return content;

        content = File.ReadAllText(filePath);

        return content;
    }
}