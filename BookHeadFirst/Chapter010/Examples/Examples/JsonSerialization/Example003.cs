using System.Text.Json;
using Examples.JsonSerialization.Models;

namespace Examples.JsonSerialization;

public static class Example003 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "Guys.json";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        if (!File.Exists(filePath)) return;

        string jsonString = File.ReadAllText(filePath);

        if (string.IsNullOrWhiteSpace(jsonString)) return;

        var guys = JsonSerializer.Deserialize<Stack<Dude>>(jsonString);

        if (guys == null) return;

        while (guys.Count > 0) {
            Dude dude = guys.Pop();
            Console.WriteLine($"Next dude: {dude.Name} with {dude.Hair} hair");
        }
    }

    private static readonly JsonSerializerOptions JasonReadOptions = new() {
        AllowTrailingCommas = true
    };
}