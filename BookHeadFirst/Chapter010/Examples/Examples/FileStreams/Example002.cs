namespace Examples.FileStreams;

public static class Example002 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "SecondFile.txt";
        string directoryPath = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryPath, fileName);

        if (!Directory.Exists(directoryPath)) return;

        StreamWriter writer = CreateStreamWriter(filePath);

        WriteSomething(writer, "This is something.");
        WriteSomething(writer, "This is something else.");
        CloseStreamWriter(writer);

        try {
            writer.WriteLine("Trying to write after stream write was closed..");
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }

    private static StreamWriter CreateStreamWriter(string filePath) {
        var writer = new StreamWriter(filePath);
        writer.WriteLine("Writing after created stream writer.");

        return writer;
    }

    private static void CloseStreamWriter(StreamWriter writer) {
        writer.WriteLine("Writing before close stream writer.");
        writer.Close();
    }

    private static void WriteSomething(StreamWriter writer, string content) {
        try {
            writer.WriteLine(content);
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}