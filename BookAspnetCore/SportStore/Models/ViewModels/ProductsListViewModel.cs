namespace SportStore.Models.ViewModels;

public class ProductsListViewModel {
    public IEnumerable<Product> Products { get; init; } = Enumerable.Empty<Product>();
    public PagingInfo PagingInfo { get; init; } = new PagingInfo();
}