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

    public static void Write(Response response) {
        if (!File.Exists(DatabasePath)) {
            using StreamWriter sw = File.CreateText(DatabasePath);
            sw.Write(response.ToJson());
        }

        using (StreamWriter sw = File.AppendText(DatabasePath)) {
            sw.WriteLine(response.ToJson());
        }
    }

    public static IEnumerable<Response> ReadAll() {
        if (!File.Exists(DatabasePath)) return [];

        using StreamReader sr = File.OpenText(DatabasePath);

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