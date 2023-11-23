using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Section016_ExtensionMethods.Extension; 

public static class StringExtension {

    public static string Cut(this string thisObj, int size) {

        if (thisObj.Length < size) {
            return thisObj;
        }
        
        string newStr = thisObj.Substring(0, size);
        newStr = string.Concat(newStr, "...");
        
        return newStr;
    }

    public static string ToTitleCase(this string thisObj) {

        if (string.IsNullOrEmpty(thisObj) || string.IsNullOrWhiteSpace(thisObj) || thisObj.Length == 0) {
            return "";
        }

        StringBuilder sb = new StringBuilder();
        string[] textParts = thisObj.Split(' ');

        for (int i = 0; i < textParts.Length; i++) {
            string text = textParts[i];

            sb.Append(text[0].ToString().ToUpper());
            sb.Append(text.ToLower().Substring(1) + " ");
        }

        return sb.ToString();
    }
}