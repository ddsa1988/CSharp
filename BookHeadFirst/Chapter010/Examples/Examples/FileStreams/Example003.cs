using System.Text;

namespace Examples.FileStreams;

public static class Example003 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "LoremIpsum.txt";
        string directoryName = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryName, fileName);

        if (!File.Exists(filePath)) return;

        var reader = new StreamReader(filePath);
        var stringBuilder = new StringBuilder();

        while (!reader.EndOfStream) {
            string? line = reader.ReadLine();
            stringBuilder.AppendLine(line);
        }

        reader.Close();

        Console.WriteLine(stringBuilder.ToString());
    }
}