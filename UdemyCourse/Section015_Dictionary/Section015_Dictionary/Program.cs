namespace Section015_Dictionary;

public class Program {
    public static void Main(string[] args) {

        char separator = Path.AltDirectorySeparatorChar;
        string sourcePath = @$"..{separator}..{separator}..{separator}/Files{separator}Votes.txt";

        if (File.Exists(sourcePath)) {

            Dictionary<string, int> candidates = new Dictionary<string, int>();

            candidates.Add("diego", 1000);
            PrintCollection(candidates);

            try {
                using StreamReader sr = new StreamReader(sourcePath);

                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }


            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }

    public static void PrintCollection<T>(IEnumerable<T> collection) {

        foreach (T item in collection) {
            Console.WriteLine(item);
        }
    }

    public static bool IsDataValid(string text) {

        if(string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) return false;

        if (!text.Contains(',')) return false;

        try {
            string[] textParts = text.Split(",");

            return true;

        } catch (Exception e) {
            Console.WriteLine(e.Message);
            return false;
        }
    }
}