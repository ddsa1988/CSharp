namespace SportStore.Models.ViewModels;

public class ProductsListViewModel {
    public IEnumerable<Product> Products { get; init; } = [];
    public PagingInfo PagingInfo { get; init; } = new();
    public string? CurrentCategory { get; set; }
}