namespace Examples.BinaryWriterAndReader;

public static class Example002 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "BinaryData.txt";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        if (!File.Exists(filePath)) return;

        using FileStream fileStream = File.OpenRead(filePath);
        using var reader = new BinaryReader(fileStream);

        int intRead = reader.ReadInt32();
        string stringRead = reader.ReadString();
        byte[] byteArrayRead = reader.ReadBytes(4);
        float floatRead = reader.ReadSingle();
        char charRead = reader.ReadChar();

        string byteArrayReadString = $"[{string.Join(", ", byteArrayRead)}]";

        Console.WriteLine(
            $"int: {intRead}, string: {stringRead}, byteArray: {byteArrayReadString}, float: {floatRead}, char: {charRead}");
    }
}