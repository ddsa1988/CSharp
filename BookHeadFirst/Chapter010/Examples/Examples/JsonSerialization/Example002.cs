using System.Text.Json;
using Examples.JsonSerialization.Models;

namespace Examples.JsonSerialization;

public static class Example002 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "Guys.json";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        if (!File.Exists(filePath)) return;

        string jsonString = File.ReadAllText(filePath);

        if (string.IsNullOrWhiteSpace(jsonString)) return;

        var guys = JsonSerializer.Deserialize<List<Guy>>(jsonString);

        if (guys == null) return;

        foreach (Guy guy in guys) {
            Console.WriteLine(guy);
        }
    }

    private static readonly JsonSerializerOptions JasonReadOptions = new() {
        AllowTrailingCommas = true
    };
}