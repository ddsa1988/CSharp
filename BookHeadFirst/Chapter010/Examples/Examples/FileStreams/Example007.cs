namespace Examples.FileStreams;

public static class Example007 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "LoremIpsum.txt";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        if (!File.Exists(filePath)) return;

        // using (var sr = new StreamReader(filePath)) {
        //     while (!sr.EndOfStream) {
        //         Console.WriteLine(sr.ReadLine());
        //     }
        // }

        using var sr = new StreamReader(filePath);

        while (!sr.EndOfStream) {
            Console.WriteLine(sr.ReadLine());
        }
    }
}