namespace Examples.BinaryWriterAndReader;

public static class Example002 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "BinaryData.txt";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        if (!File.Exists(filePath)) return;
    }
}