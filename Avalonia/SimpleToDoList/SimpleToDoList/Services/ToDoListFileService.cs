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
        IEnumerable<ToDoItem> toDoItems = itemsToSave.ToArray();

        if (!toDoItems.Any()) return;

        if (!Directory.Exists(DirectoryPath)) {
            Directory.CreateDirectory(DirectoryPath);
        }

        if (File.Exists(FilePath)) {
            File.Delete(FilePath);
        }

        try {
            string content = JsonSerializer.Serialize(toDoItems, JsonWriteOptions);
            await File.WriteAllTextAsync(FilePath, content);
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }

    public static async Task<IEnumerable<ToDoItem>> LoadFromFileAsync() {
        if (!File.Exists(FilePath)) return Enumerable.Empty<ToDoItem>();

        IEnumerable<ToDoItem>? toDoItems = new List<ToDoItem>();

        try {
            string content = await File.ReadAllTextAsync(FilePath);
            toDoItems = JsonSerializer.Deserialize<IEnumerable<ToDoItem>>(content, JsonReadOptions);
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }

        return toDoItems ?? Enumerable.Empty<ToDoItem>();
    }
}