namespace SportStore.Models.ViewModels;

public class PagingInfo {
    public int TotalItems { get; init; }
    public int ItemsPerPage { get; init; }
    public int CurrentPage { get; init; }
    public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
}