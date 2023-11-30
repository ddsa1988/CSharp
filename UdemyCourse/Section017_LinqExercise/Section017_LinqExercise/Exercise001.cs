using System.Globalization;
using Section017_LinqExercise.Entities;

namespace Section017_LinqExercise;

public class Exercise001 {
    public static void CallMain() {
        char separator = Path.AltDirectorySeparatorChar;
        string sourcePath = @$"..{separator}..{separator}..{separator}Files{separator}Products.txt";

        List<Product> products = new List<Product>();

        if (!File.Exists(sourcePath)) return;

        using StreamReader sr = new StreamReader(sourcePath);
        while (!sr.EndOfStream) {
            string? data = sr.ReadLine();

            if (!IsDataValid(data)) continue;

            string[] dataArray = data.Split(',');
            string name = dataArray[0].Trim();
            float price = float.Parse(dataArray[1]);

            Product product = new Product(name, price);
            products.Add(product);
        }
        
        if(products.Count == 0) return;

        // float average = products.Select(p => p.Price).DefaultIfEmpty(0F).Average();
        float average = (from p in products select p.Price).DefaultIfEmpty(0F).Average();
        Console.WriteLine("Average price: $" + average.ToString("F2", CultureInfo.InvariantCulture));

        // IEnumerable<string> result = products.Where(p => p.Price < average).Select(p => p.Name).OrderDescending();
        IEnumerable<string> result = from p in products where p.Price < average orderby p.Name descending select p.Name;
        PrintCollection(result);
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
        string priceString = dataArray[1];

        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) return false;

        try {
            float price = float.Parse(priceString);
        } catch (Exception e) {
            return false;
        }

        return true;
    }
}