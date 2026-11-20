using System.Globalization;
using System.Text;

namespace ObjectOrientedProgramming.Utils;

internal static class MyExtensionsMethods {
    public static string ToCapitalizeCase(this string str) {
        if (string.IsNullOrWhiteSpace(str)) return str;

        return string.Concat(str[0].ToString().ToUpperInvariant(), str.Substring(1).ToLowerInvariant());
    }

    public static string ToTitleCase(this string str) {
        if (string.IsNullOrEmpty(str)) return str;

        if (!str.Contains(' ')) return str.ToCapitalizeCase();

        string[] words = str.Split(' ');

        var sb = new StringBuilder();

        foreach (string word in words) {
            sb.Append(word.ToCapitalizeCase() + " ");
        }

        return sb.ToString().Trim();
    }
}