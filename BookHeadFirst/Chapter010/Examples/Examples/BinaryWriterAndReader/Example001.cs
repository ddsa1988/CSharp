namespace Examples.BinaryWriterAndReader;

public static class Example001 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "BinaryData.txt";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        if (!Directory.Exists(directoryPath)) {
            Directory.CreateDirectory(directoryPath);
        }

        const int intValue = 48769414;
        const string stringValue = "Hello!";
        byte[] byteArray = [47, 128, 0, 116];
        const float floatValue = 491.695f;
        const char charValue = 'E';

        using (FileStream fileStream = File.Create(filePath)) {
            using (var binaryWriter = new BinaryWriter(fileStream)) {
                binaryWriter.Write(intValue);
                binaryWriter.Write(stringValue);
                binaryWriter.Write(byteArray);
                binaryWriter.Write(floatValue);
                binaryWriter.Write(charValue);
            }
        }

        if (!File.Exists(filePath)) return;

        byte[] dataWritten = File.ReadAllBytes(filePath);

        foreach (byte b in dataWritten) {
            Console.Write($"{b:x2} ");
        }

        Console.WriteLine($"- {dataWritten.Length} bytes");
    }
}