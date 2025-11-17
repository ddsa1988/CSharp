namespace LanguageFeatures.Models;

public static class PatternMatching {
    public static decimal TheIsKeyword() {
        // The is keyword is used to perform a type test

        object[] data = [275M, 29.95M, "apple", "orange", 100, 10];
        decimal total = 0;

        foreach (object value in data) {
            if (value is not decimal decimalValue) continue;

            total += decimalValue;
        }

        return total;
    }

    public static decimal SwitchStatement() {
        object[] data = [275M, 29.95M, "apple", "orange", 100, 10];
        decimal total = 0;

        foreach (object value in data) {
            switch (value) {
                case decimal decimalValue:
                    total += decimalValue;
                    break;
                case int intValue and > 50:
                    total += intValue;
                    break;
            }
        }

        return total;
    }
}