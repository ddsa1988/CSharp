using System.Globalization;

namespace HideAndSeek.Services;

public static class ExtensionMethods {
    public static string ToTitleCase(this string input) {
        if (string.IsNullOrWhiteSpace(input)) return input;

        TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;

        return textInfo.ToTitleCase(input.ToLower());
    }
}