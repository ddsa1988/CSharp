using System.Security.Cryptography.X509Certificates;

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
}