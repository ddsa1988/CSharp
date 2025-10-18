namespace Examples.FileStreams;

public static class Example001 {
    public static void Run() {
        char sepChar = Path.DirectorySeparatorChar;
        string directoryPath = $"..{sepChar}..{sepChar}..{sepChar}FileStreams{sepChar}Files";
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}FileStreams{sepChar}Files{sepChar}FirstFile.txt";

        if (!Directory.Exists(directoryPath)) {
            return;
        }

        var writer = new StreamWriter(filePath, false);
        writer.WriteLine("This is a test");
        writer.Close();

        var reader = new StreamReader(filePath);

        while (!reader.EndOfStream) {
            Console.WriteLine(reader.ReadLine());
        }

        reader.Close();
    }
}