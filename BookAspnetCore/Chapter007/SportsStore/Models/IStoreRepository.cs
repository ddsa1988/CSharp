namespace SportsStore.Models;

public interface IStoreRepository {
    IQueryable<Product> Products { get; }

    public void CreateProduct(Product product);
    public void SaveProduct(Product product);
    public void DeleteProduct(Product product);
}