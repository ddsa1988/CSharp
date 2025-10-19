namespace Examples.FileStreams;

public static class Example001 {
    public static void Run() {
        const string folderName = "FirstFile.txt";
        char sepChar = Path.DirectorySeparatorChar;
        string directoryPath = $"..{sepChar}..{sepChar}..{sepChar}FileStreams{sepChar}Files";
        string filePath = $"{directoryPath}{sepChar}{folderName}";

        // Console.WriteLine(Environment.CurrentDirectory);
        // Console.WriteLine(Directory.GetCurrentDirectory());
        // Console.WriteLine(Path.GetFullPath(filePath));

        // if (!Path.Exists(directoryPath)) return;

        if (!Directory.Exists(directoryPath)) return;

        var writer = new StreamWriter(filePath, false);
        writer.WriteLine("This is a test");
        writer.Close();

        if (!File.Exists(filePath)) return;

        var reader = new StreamReader(filePath);

        while (!reader.EndOfStream) {
            Console.WriteLine(reader.ReadLine());
        }

        reader.Close();
    }
}