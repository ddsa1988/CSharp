using System.Globalization;
using Section013_WorkingWithFiles.Entities;

namespace Section013_WorkingWithFiles;

public class Program {
    public static void Main(string[] args) {

        CultureInfo cultureInfo = CultureInfo.InvariantCulture;

        string separator = Path.AltDirectorySeparatorChar.ToString();
        string sourcePath = @$"..{separator}..{separator}..{separator}Files{separator}Product.csv";
        string targetPath = @$"..{separator}..{separator}..{separator}Files{separator}Summary.csv";

        if (File.Exists(targetPath)) {
            File.Delete(targetPath);
        }
        
        try {
            
            string[] lines = File.ReadAllLines(sourcePath);
            using StreamWriter sw = File.AppendText(targetPath);
                
            foreach (string line in lines) {

                string[] data = line.Split(",");
                string name = data[0];
                float price = float.Parse(data[1], cultureInfo);
                int quantity = int.Parse((data[2]));

                Product product = new Product(name, price, quantity);
                string dataToWrite = $"{product.Name},{product.Total().ToString("F2", cultureInfo)}";
                sw.WriteLine(dataToWrite);
            }
        } catch (Exception e) {
                Console.WriteLine(e.Message); 
        }
    }
}