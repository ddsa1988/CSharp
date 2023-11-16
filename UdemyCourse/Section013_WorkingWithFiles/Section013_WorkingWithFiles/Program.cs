using System;
using Section013_WorkingWithFiles.Entities;

namespace Section013_WorkingWithFiles;

public class Program {
    public static void Main(string[] args) {

        const string sourcePath = "../Files/Product.csv";
        List<Product> products = new List<Product>();

        if (File.Exists(sourcePath)) {
            try {
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines) {
                    
                    string[] data = line.Split(",");
                    string name = data[0];
                    float price = float.Parse(data[1]);
                    int quantity = int.Parse((data[2]));
                    
                    products.Add(new Product(name, price, quantity));
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            foreach (Product product in products) {
                Console.WriteLine(product + "\n");
            }
        }
    }
}