namespace Platform.ExtensionMethod;

public static class ExtensionMethod {
    public static string Capitalize(this string str) {
        if (string.IsNullOrWhiteSpace(str)) return str;

        return char.ToUpper(str[0]) + str.Substring(1).ToLower();
    }
}