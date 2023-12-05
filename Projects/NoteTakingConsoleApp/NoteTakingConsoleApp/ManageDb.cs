using System.Text;

namespace NoteTakingConsoleApp;

public class ManageDb {
    public string SourcePath { get; set; }

    public ManageDb(string sourcePath) {
        SourcePath = sourcePath;
    }

    public void ReadDb(List<string> notes) {
        if (!Path.Exists(SourcePath)) return;

        using StreamReader sr = new StreamReader(SourcePath);

        while (!sr.EndOfStream) {
            string? data = sr.ReadLine();

            if (!IsStringValid(data)) continue;

            notes.Add(data);
        }
    }

    public void UpdateDb(List<string> notes) {
        if (notes.Count == 0) return;

        StringBuilder sb = new StringBuilder();

        foreach (string note in notes) {
            sb.Append(note + "\n");
        }

        File.Delete(SourcePath);

        FileInfo fileInfo = new FileInfo(SourcePath);

        using StreamWriter sw = File.AppendText(SourcePath);
        sw.WriteLine(sb.ToString());
    }

    private static bool IsStringValid(string value) {
        return !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value));
    }
}