using Microsoft.AspNetCore.Mvc;
using SimpleApp.Controllers;
using SimpleApp.Models;
using Moq;

namespace SimpleAppTests;

public class HomeControllerTests {
    [Fact]
    private void IndexActionModelIsComplete() {
        // Arrange
        var testData = new Product[] {
            new() { Name = "P1", Price = 75.10M },
            new() { Name = "P2", Price = 120M },
            new() { Name = "P3", Price = 110M }
        };

        var mock = new Mock<IDataSource>();
        mock.Setup(m => m.Products).Returns(testData);
        var controller = new HomeController();
        controller.DataSource = mock.Object;

        // Act
        var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;

        // Assert
        Assert.Equal(testData, model,
            Comparer.Get<Product>((p1, p2) => p1?.Name == p2?.Name && p1?.Price == p2?.Price));

        mock.Verify(m => m.Products, Times.Once);
    }
}