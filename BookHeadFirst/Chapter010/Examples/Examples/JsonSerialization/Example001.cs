using System.Text.Json;
using Examples.JsonSerialization.Models;

namespace Examples.JsonSerialization;

public static class Example001 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "Guys.json";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        List<Guy> guys = [
            new() {
                Name = "Bob", Clothes = new Outfit() { Top = "t-shirt", Bottom = "jeans" },
                Hair = new HairStyle() { Color = HairColor.Red, Length = 3.5f }
            },

            new() {
                Name = "Joe", Clothes = new Outfit() { Top = "polo", Bottom = "slacks" },
                Hair = new HairStyle() { Color = HairColor.Gray, Length = 2.7f }
            }
        ];

        string jsonString = JsonSerializer.Serialize(guys, JsonWriteOptions);
        Console.WriteLine(jsonString);

        if (!Directory.Exists(directoryPath)) {
            Directory.CreateDirectory(directoryPath);
        }

        if (File.Exists(filePath)) {
            File.Delete(filePath);
        }

        File.WriteAllText(filePath, jsonString);
    }

    private static readonly JsonSerializerOptions JsonWriteOptions = new() {
        WriteIndented = true
    };
}