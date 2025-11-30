using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStoreTests;

public class HomeControllerTests {
    [Fact]
    public void CanUseRepository() {
        // Arrange
        var mock = new Mock<IStoreRepository>();
        mock.Setup(m => m.Products).Returns(new Product[] {
            new() { ProductId = 1, Name = "P1" },
            new() { ProductId = 2, Name = "P2" },
        }.AsQueryable());

        var controller = new HomeController(mock.Object);

        // Act
        ProductsListViewModel result = controller.Index().ViewData.Model as ProductsListViewModel ??
                                       new ProductsListViewModel();

        // Assert
        Product[] prodArray = result.Products.ToArray();

        Assert.Equal(2, prodArray.Length);
        Assert.Equal("P1", prodArray[0].Name);
        Assert.Equal("P2", prodArray[1].Name);
    }

    [Fact]
    public void CanPaginate() {
        // Arrange
        var mock = new Mock<IStoreRepository>();
        mock.Setup(m => m.Products).Returns(new Product[] {
            new() { ProductId = 1, Name = "P1" },
            new() { ProductId = 2, Name = "P2" },
            new() { ProductId = 3, Name = "P3" },
            new() { ProductId = 4, Name = "P4" },
            new() { ProductId = 5, Name = "P5" }
        }.AsQueryable());

        var controller = new HomeController(mock.Object);
        controller.PageSize = 3;

        // Act
        ProductsListViewModel result = controller.Index(2).ViewData.Model as ProductsListViewModel ??
                                       new ProductsListViewModel();

        // Assert
        Product[] prodArray = result.Products.ToArray();

        Assert.True(prodArray.Length == 2);
        Assert.Equal("P4", prodArray[0].Name);
        Assert.Equal("P5", prodArray[1].Name);
    }

    [Fact]
    public void CanSendPaginationViewModel() {
        // Arrange
        var mock = new Mock<IStoreRepository>();
        mock.Setup(m => m.Products).Returns((new Product[] {
            new() { ProductId = 1, Name = "P1" },
            new() { ProductId = 2, Name = "P2" },
            new() { ProductId = 3, Name = "P3" },
            new() { ProductId = 4, Name = "P4" },
            new() { ProductId = 5, Name = "P5" }
        }).AsQueryable());

        var controller = new HomeController(mock.Object) {
            PageSize = 3
        };

        // Act
        ProductsListViewModel result = controller.Index(2).ViewData.Model as ProductsListViewModel ??
                                       new ProductsListViewModel();

        // Assert
        PageInfo pageInfo = result.PageInfo;
        Assert.Equal(2, pageInfo.CurrentPage);
        Assert.Equal(3, pageInfo.ItemsPerPage);
        Assert.Equal(5, pageInfo.TotalItems);
        Assert.Equal(2, pageInfo.TotalPages);
    }
}