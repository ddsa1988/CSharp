using System.Text;

namespace Chapter006.Strings;

public static class Example014 {
    public static void Run() {
        // StringBuilder insert, replace and remove data

        string[] names = ["Diego", "Amanda", "Amora", "Ameixa"];

        var sb = new StringBuilder();
        sb.AppendJoin(", ", names);

        Console.WriteLine(sb.ToString());

        sb.Insert(5, "Rodrigo");
        sb.Remove(0, 5);
        sb.Replace("Amanda", "Leticia");
        Console.WriteLine(sb.ToString());
    }
}