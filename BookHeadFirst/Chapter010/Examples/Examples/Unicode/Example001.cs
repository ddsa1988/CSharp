using System.Text;

namespace Examples.Unicode;

public static class Example001 {
    public static void Run() {
        const string folderName = "Files";
        const string fileName = "Eureka.txt";
        string directoryName = AppContext.BaseDirectory + folderName;
        string filePath = Path.Combine(directoryName, fileName);

        if (!Directory.Exists(directoryName)) {
            Directory.CreateDirectory(directoryName);
        }

        if (File.Exists(filePath)) {
            File.Delete(filePath);
        }

        File.WriteAllText(filePath, "Eureka!");

        if (!File.Exists(filePath)) return;

        byte[] bytes = File.ReadAllBytes(filePath);

        Console.Write("Values in decimal: ");

        foreach (byte value in bytes) {
            Console.Write("{0} ", value);
        }

        Console.WriteLine();

        Console.Write("Value in hexadecimal: ");

        foreach (byte value in bytes) {
            Console.Write("{0:x} ", value);
        }

        Console.WriteLine();
        Console.WriteLine("String: " + Encoding.UTF8.GetString(bytes));
    }
}