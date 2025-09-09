namespace BeehiveManagementSystem.Extensions;

public static class ExtensionMethods {
    public static string PascalCaseToTitleCase(this string str) {
        if (string.IsNullOrEmpty(str)) return string.Empty;

        int strLength = str.Length;
        string newStr = str.Substring(0, 1);

        for (int i = 1; i < strLength; i++) {
            char ch = str[i];

            if (char.IsUpper(ch)) {
                newStr += " " + ch;
            } else {
                newStr += ch;
            }
        }

        return newStr;
    }
}