namespace Chapter006.Strings;

public static class Example001 {
    public static void Run() {
        // Char

        char[] chars = ['A', 'a', '1', ' ', '.', '_', '+', '\r'];

        foreach (char c in chars) {
            if (char.IsLetter(c)) Console.WriteLine("{0} is letter.", c);
            if (char.IsUpper(c)) Console.WriteLine("{0} is upper case.", c);
            if (char.IsLower(c)) Console.WriteLine("{0} is lower case.", c);
            if (char.IsDigit(c)) Console.WriteLine("{0} is digit.", c);
            if (char.IsLetterOrDigit(c)) Console.WriteLine("{0} is letter or digit.", c);
            if (char.IsSeparator(c)) Console.WriteLine("{0} is separator.", c);
            if (char.IsWhiteSpace(c)) Console.WriteLine("{0} is whitespace.", c);
            if (char.IsPunctuation(c)) Console.WriteLine("{0} is punctuation.", c);
            if (char.IsSymbol(c)) Console.WriteLine("{0} is symbol.", c);
            if (char.IsControl(c)) Console.WriteLine("{0} is control.", c);
        }
    }
}