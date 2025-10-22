namespace Examples.FileStreams;

public static class Example004 {
    public static void Run() {
        const string folderName = "Files";
        char sepChar = Path.DirectorySeparatorChar;
        string directoryPath = AppContext.BaseDirectory + folderName;

        string[] files = Directory.GetFiles(directoryPath);

        foreach (string file in files) {
            Console.WriteLine($"Full path: {file}");
            Console.WriteLine($"File name: {Path.GetFileName(file)}");
            Console.WriteLine($"File name: {file.Split(sepChar).Last()}\n");
        }
    }
}