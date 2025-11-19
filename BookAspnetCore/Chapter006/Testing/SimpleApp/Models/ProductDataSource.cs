namespace SimpleApp.Models;

public class ProductDataSource : IDataSource {
    public IEnumerable<Product> Products => [
        new() { Name = "Kayak", Price = 275M },
        new() { Name = "Life Jacket", Price = 48.95M }
    ];
}