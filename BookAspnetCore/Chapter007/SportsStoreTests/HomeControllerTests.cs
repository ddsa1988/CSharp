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
}