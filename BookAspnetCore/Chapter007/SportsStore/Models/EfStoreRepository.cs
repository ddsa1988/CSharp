namespace SportsStore.Models;

public class EfStoreRepository : IStoreRepository {
    private readonly StoreDbContext _context;

    public EfStoreRepository(StoreDbContext context) {
        _context = context;
    }

    public IQueryable<Product> Products => _context.Products;

    public void CreateProduct(Product product) {
        _context.Add(product);
        _context.SaveChanges();
    }

    public void DeleteProduct(Product product) {
        _context.Remove(product);
        _context.SaveChanges();
    }

    public void SaveProduct(Product product) {
        _context.SaveChanges();
    }
}