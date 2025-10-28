namespace Examples.BinaryWriterAndReader;

public static class Example003 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "ThirdFile.txt";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        if (!File.Exists(filePath)) return;

        int position = 0;
        using var reader = new StreamReader(filePath);

        while (!reader.EndOfStream) {
            char[] buffer = new char[16];
            int bytesRead = reader.ReadBlock(buffer, 0, 16);

            Console.Write($"{position:x4} ");
            position += bytesRead;

            for (int i = 0; i < 16; i++) {
                Console.Write(i < bytesRead ? $"{(byte)buffer[i]:x2} " : "  ");

                if (i == 7) {
                    Console.Write("-- ");
                }
            }

            string bufferContents = new(buffer);
            Console.WriteLine(string.Concat(" ", bufferContents.AsSpan(0, bytesRead)));
        }
    }
}