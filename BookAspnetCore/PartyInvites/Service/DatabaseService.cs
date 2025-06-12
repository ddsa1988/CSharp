using PartyInvites.Mapping;
using PartyInvites.Models;

namespace PartyInvites.Service;

public static class DatabaseService {
    private const string FolderName = "Database";
    private const string FileName = "Database.txt";
    private static readonly char SepChar = Path.DirectorySeparatorChar;
    private static readonly string FilePath = $"{FolderName}{SepChar}{FileName}";

    public static void PrintFilePath() {
        Console.WriteLine(Path.GetFullPath(FilePath));
        Console.WriteLine(File.Exists(FilePath));
    }

    public static void Write(Response response) {
        if (!File.Exists(FilePath)) {
            using StreamWriter sw = File.CreateText(FilePath);
            sw.Write(response.ToJson());
        }

        using (StreamWriter sw = File.AppendText(FilePath)) {
            sw.WriteLine(response.ToJson());
        }
    }

    public static IEnumerable<Response> ReadAll() {
        if (!File.Exists(FilePath)) return [];

        using StreamReader sr = File.OpenText(FilePath);

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