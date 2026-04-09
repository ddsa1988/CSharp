using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using SimpleToDoList.Models;

namespace SimpleToDoList.Services;

public static class ToDoListFileService {
    private const string FolderName = "Database";
    private const string FileName = "ToDoList.json";
    private static readonly string DirectoryPath = Path.Combine(AppContext.BaseDirectory, FolderName);
    private static readonly string FilePath = Path.Combine(DirectoryPath, FileName);

    private static readonly JsonSerializerOptions JsonWriteOptions = new() {
        WriteIndented = true
    };

    private static readonly JsonSerializerOptions JsonReadOptions = new() {
        AllowTrailingCommas = true
    };

    public static async Task SaveToFileAsync(IEnumerable<ToDoItem> itemsToSave) {
        IEnumerable<ToDoItem> items = itemsToSave.ToArray();

        if (!items.Any()) return;

        if (!Directory.Exists(DirectoryPath)) {
            Directory.CreateDirectory(DirectoryPath);
        }

        if (File.Exists(FilePath)) {
            File.Delete(FilePath);
        }

        try {
            string data = JsonSerializer.Serialize(items, JsonWriteOptions);
            await File.WriteAllTextAsync(FilePath, data);
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}