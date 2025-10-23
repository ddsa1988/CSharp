using System.Text;

namespace Examples.FileStreams;

public static class Example006 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "ThirdFile.txt";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        if (!Directory.Exists(directoryPath)) {
            Directory.CreateDirectory(directoryPath);
        }

        FileStream filestream = File.OpenWrite(filePath);
        byte[] bytes = new UTF8Encoding(true).GetBytes("This is to test the OpenWrite method.");
        filestream.Write(bytes, 0, bytes.Length);

        filestream.Close();

        filestream = File.OpenRead(filePath);
        bytes = new byte[filestream.Length];
        var encode = new UTF8Encoding(true);

        filestream.ReadExactly(bytes, 0, bytes.Length);
        Console.WriteLine(encode.GetString(bytes));

        filestream.Close();
    }
}