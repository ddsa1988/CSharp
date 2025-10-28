using System.Text;

namespace Examples.BinaryWriterAndReader;

public static class Example004 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "BinaryData.txt";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        if (!File.Exists(filePath)) return;

        int position = 0;
        using FileStream reader = File.OpenRead(filePath);

        byte[] buffer = new byte[16];

        while (position < reader.Length) {
            int bytesRead = reader.Read(buffer, 0, 16);

            Console.Write($"{position:x4} ");
            position += bytesRead;

            for (int i = 0; i < 16; i++) {
                Console.Write(i < bytesRead ? $"{buffer[i]:x2} " : "  ");

                if (i == 7) {
                    Console.Write("-- ");
                }
            }

            string bufferContents = Encoding.UTF8.GetString(buffer);
            Console.WriteLine(string.Concat(" ", bufferContents.AsSpan(0, bytesRead)));
        }
    }
}