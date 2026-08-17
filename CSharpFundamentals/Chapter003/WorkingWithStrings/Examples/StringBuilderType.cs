using System.Text;

namespace WorkingWithStrings.Examples;

internal static class StringBuilderType {
    internal static void Run() {
        Console.WriteLine("=> Using StringBuilder:\n");

        var sb = new StringBuilder("***** Fantastic Games *****");
        sb.Append(Environment.NewLine);
        sb.AppendLine("Half Life");
        sb.AppendLine("Morrowind");
        sb.AppendLine("Deus Ex " + "2");
        sb.AppendLine("System Shock");

        Console.WriteLine(sb.ToString());

        sb.Replace("2", "Invisible War");
        Console.WriteLine(sb.ToString());

        Console.WriteLine($"{nameof(sb)} has {sb.Length} chars.");
    }
}