using PartyInvites.Mapping;
using PartyInvites.Models;

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

    public static void WriteAll(string filePath, IEnumerable<Response> responses) {
        if (File.Exists(filePath)) {
            File.Delete(filePath);
        }

        using FileStream fs = File.Create(filePath);
        using var sw = new StreamWriter(fs);

        foreach (Response guestResponse in responses) {
            sw.Write(guestResponse.ToJson());
        }
    }

    public static IEnumerable<Response> ReadAll(string filePath) {
        if (!File.Exists(filePath)) return [];

        using var sr = new StreamReader(filePath);

        var responses = new List<Response>();

        while (!sr.EndOfStream) {
            string? line = sr.ReadLine();

            Response? response = line?.ToModel();

            if (response == null) continue;

            responses.Add(response);
        }

        return responses;
    }
}