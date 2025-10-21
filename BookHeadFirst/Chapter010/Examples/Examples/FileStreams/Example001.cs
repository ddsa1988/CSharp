namespace Examples.FileStreams;

public static class Example001 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "FirstFile.txt";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        // Console.WriteLine(Environment.CurrentDirectory);
        // Console.WriteLine(Directory.GetCurrentDirectory());
        // Console.WriteLine(Path.GetFullPath(filePath));

        // if (!Path.Exists(directoryPath)) {
        //     Directory.CreateDirectory(directoryPath);
        // }

        if (!Directory.Exists(directoryPath)) {
            Directory.CreateDirectory(directoryPath);
        }

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