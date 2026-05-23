namespace WorkingWithArrays.Examples;

public static class ArrayOfReferenceTypes1 {
    public static void Run() {
        string[] words = new string[10];

        Console.WriteLine(words.Length);

        foreach (string word in words) {
            Console.Write((word ?? "null") + ", ");
        }

        for (int i = 0; i < words.Length; i++) {
            words[i] = i.ToString();
        }

        Console.WriteLine();

        foreach (string word in words) {
            Console.Write((word ?? "null") + ", ");
        }
    }
}