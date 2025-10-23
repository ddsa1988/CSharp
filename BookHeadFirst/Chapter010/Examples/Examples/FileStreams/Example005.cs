using System.Text;

namespace Examples.FileStreams;

public static class Example005 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "FirstFile.txt";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        if (!File.Exists(filePath)) return;

        FileStream fileStream = File.OpenRead(filePath);

        byte[] bytes = new byte[fileStream.Length];
        var encode = new UTF8Encoding(true);

        while (fileStream.Read(bytes, 0, bytes.Length) > 0) {
            string temp = encode.GetString(bytes);
            Console.WriteLine(temp);
        }

        fileStream.Close();

        fileStream = File.OpenRead(filePath);

        fileStream.ReadExactly(bytes, 0, bytes.Length);

        foreach (byte value in bytes) {
            Console.WriteLine($"Byte: {value}, Char: {(char)value}");
        }

        fileStream.Close();
    }
}