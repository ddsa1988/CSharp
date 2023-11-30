namespace Section017_LinqExercise;

public class Exercise002 {
    public static void CallMain() {
        char separator = Path.AltDirectorySeparatorChar;
        string sourcePath = @$"..{separator}..{separator}..{separator}Files{separator}Employees.txt";
        
        if(!File.Exists(sourcePath)) return;

        using StreamReader sr = new StreamReader(sourcePath);
        while (!sr.EndOfStream) {
            string? data = sr.ReadLine();
            Console.WriteLine(IsDataValid(data));
        }
    }

    private static void PrintCollection<T>(IEnumerable<T> collection) {
        foreach (T obj in collection) {
            Console.WriteLine(obj);
        }

        Console.WriteLine();
    }

    private static bool IsDataValid(string data) {
        if (string.IsNullOrEmpty(data) || string.IsNullOrWhiteSpace(data)) return false;
        if (!data.Contains(',')) return false;

        string[] dataArray = data.Split(',');
        string name = dataArray[0];
        string email = dataArray[1];
        string salaryString = dataArray[2];

        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) return false;
        if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email)) return false;

        try {
            float salary = float.Parse(salaryString);
        } catch (Exception e) {
            return false;
        }

        return true;
    }
}