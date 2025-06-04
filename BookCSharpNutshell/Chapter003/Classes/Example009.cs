namespace Chapter003.Classes;

public static class Example009 {
    public static void Run() {
        // To write an indexer, define a property called this, specifying the arguments in square brackets.

        var sentence = new Sentence();

        Console.WriteLine(sentence[0]);
        Console.WriteLine(sentence[3]);

        sentence[3] = "dog";

        Console.WriteLine(sentence[3]);
        Console.WriteLine(sentence[^2]);
        Console.WriteLine(string.Join(", ", sentence[..2]));
    }

    private class Sentence {
        private readonly string[] _words = "The quick brown fox".Split(' ');

        public string this[int index] {
            get => _words[index];
            set => _words[index] = value;
        }

        public string this[Index index] {
            get => _words[index];
            set => _words[index] = value;
        }

        public string[] this[Range range] => _words[range];
    }
}