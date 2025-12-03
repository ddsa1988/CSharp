using Microsoft.AspNetCore.Mvc;
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
        ProductsListViewModel result = controller.Index(null).ViewData.Model as ProductsListViewModel ??
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
        ProductsListViewModel result = controller.Index(null, 2).ViewData.Model as ProductsListViewModel ??
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
        mock.Setup(m => m.Products).Returns(new Product[] {
            new() { ProductId = 1, Name = "P1" },
            new() { ProductId = 2, Name = "P2" },
            new() { ProductId = 3, Name = "P3" },
            new() { ProductId = 4, Name = "P4" },
            new() { ProductId = 5, Name = "P5" }
        }.AsQueryable());

        var controller = new HomeController(mock.Object) {
            PageSize = 3
        };

        // Act
        ProductsListViewModel result = controller.Index(null, 2).ViewData.Model as ProductsListViewModel ??
                                       new ProductsListViewModel();

        // Assert
        PageInfo pageInfo = result.PageInfo;
        Assert.Equal(2, pageInfo.CurrentPage);
        Assert.Equal(3, pageInfo.ItemsPerPage);
        Assert.Equal(5, pageInfo.TotalItems);
        Assert.Equal(2, pageInfo.TotalPages);
    }

    [Fact]
    public void CanFilterProducts() {
        // Arrange
        var mock = new Mock<IStoreRepository>();
        mock.Setup(m => m.Products).Returns(new Product[] {
            new() { ProductId = 1, Name = "P1", Category = "Cat1" },
            new() { ProductId = 2, Name = "P2", Category = "Cat2" },
            new() { ProductId = 3, Name = "P3", Category = "Cat1" },
            new() { ProductId = 4, Name = "P4", Category = "Cat2" },
            new() { ProductId = 5, Name = "P5", Category = "Cat3" }
        }.AsQueryable());

        // Act
        var controller = new HomeController(mock.Object);
        controller.PageSize = 3;

        Product[] result = (controller.Index("Cat2", 1).ViewData.Model as ProductsListViewModel ??
                            new ProductsListViewModel()).Products.ToArray();

        // Assert
        Assert.Equal(2, result.Length);
        Assert.True(result[0].Name.Equals("P2") && result[0].Category.Equals("Cat2"));
        Assert.True(result[1].Name.Equals("P4") && result[1].Category.Equals("Cat2"));
    }

    [Fact]
    public void CanGenerateCategorySpecificProductCount() {
        // Arrange
        var mock = new Mock<IStoreRepository>();
        mock.Setup(m => m.Products).Returns(new Product[] {
            new() { ProductId = 1, Name = "P1", Category = "Cat1" },
            new() { ProductId = 2, Name = "P2", Category = "Cat2" },
            new() { ProductId = 3, Name = "P3", Category = "Cat1" },
            new() { ProductId = 4, Name = "P4", Category = "Cat2" },
            new() { ProductId = 5, Name = "P5", Category = "Cat3" }
        }.AsQueryable());

        var target = new HomeController(mock.Object);
        target.PageSize = 3;

        Func<ViewResult, ProductsListViewModel?> getModel = result => result.ViewData.Model as ProductsListViewModel;

        // Action
        int? res1 = getModel(target.Index("Cat1"))?.PageInfo.TotalItems;
        int? res2 = getModel(target.Index("Cat2"))?.PageInfo.TotalItems;
        int? res3 = getModel(target.Index("Cat3"))?.PageInfo.TotalItems;
        int? resAll = getModel(target.Index(null))?.PageInfo.TotalItems;

        // Assert
        Assert.Equal(2, res1);
        Assert.Equal(2, res2);
        Assert.Equal(1, res3);
        Assert.Equal(5, resAll);
    }
}