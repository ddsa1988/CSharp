using Microsoft.AspNetCore.Mvc;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;

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
        var result = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;

        // Assert
        Product[] prodArray = result?.ToArray() ?? [];

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
        var result = (controller.Index(2) as ViewResult)?.ViewData.Model as IEnumerable<Product>;

        // Assert
        Product[] prodArray = result?.ToArray() ?? [];

        Assert.True(prodArray.Length == 2);
        Assert.Equal("P4", prodArray[0].Name);
        Assert.Equal("P5", prodArray[1].Name);
    }
}