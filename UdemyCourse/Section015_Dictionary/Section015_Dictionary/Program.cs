namespace Section015_Dictionary;

public class Program {
    public static void Main(string[] args) {

        char separator = Path.AltDirectorySeparatorChar;
        string sourcePath = @$"..{separator}..{separator}..{separator}/Files{separator}Votes.txt";

        if (!File.Exists(sourcePath)) return;
        
        Dictionary<string, int> candidates = new Dictionary<string, int>();

        try {
            using StreamReader sr = new StreamReader(sourcePath);

            while (!sr.EndOfStream) {
                string line = sr.ReadLine();
                    
                if(!IsDataValid(line)) continue;

                string[] lineArr = line.Split(',');
                string name = lineArr[0];
                int votes = int.Parse(lineArr[1]);

                if (!candidates.TryAdd(name, votes)) {
                    candidates[name] += votes;
                }
            }
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        // PrintCollection(candidates);
            
        foreach (KeyValuePair<string, int> item in candidates) {
            Console.WriteLine(item.Key + ": " + item.Value);
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
        
        string[] textParts = text.Split(",");

        if (textParts.Length != 2) return false;
        
        try {
            string name = textParts[0];
            int votes = int.Parse(textParts[1]);

            return !string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name) && votes >= 0;
        } catch (Exception e) {
            // Console.WriteLine(e.Message);
            return false;
        }
    }
}