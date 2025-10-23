using System.Text;

namespace Examples.FileStreams;

public static class Example008 {
    public static void Run() {
        // using (var ms = new MemoryStream())
        // using (var sw = new StreamWriter(ms)) {
        //     sw.WriteLine("Hello World!");
        //
        //     // It doesn't work. The ms.ToArray() is called before the StreamWriter is closed.
        //     // StreamWriter don't write all the data until is closed.
        //     Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
        // }

        using var ms = new MemoryStream();
        using (var sw = new StreamWriter(ms)) {
            sw.WriteLine("Hello World!");
        }

        Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
    }
}