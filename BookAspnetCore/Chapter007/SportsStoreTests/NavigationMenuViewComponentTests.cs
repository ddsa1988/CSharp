using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Moq;
using SportsStore.Components;
using SportsStore.Models;

namespace SportsStoreTests;

public class NavigationMenuViewComponentTests {
    private static readonly string[] First = ["Apples", "Oranges", "Plums"];

    [Fact]
    public void CanSelectCategories() {
        // Arrange
        var mock = new Mock<IStoreRepository>();
        mock.Setup(m => m.Products).Returns(new Product[] {
            new() { ProductId = 1, Name = "P1", Category = "Apples" },
            new() { ProductId = 2, Name = "P2", Category = "Apples" },
            new() { ProductId = 3, Name = "P3", Category = "Plums" },
            new() { ProductId = 4, Name = "P4", Category = "Oranges" },
        }.AsQueryable());

        var target = new NavigationMenuViewComponent(mock.Object);

        // Act
        string[] results = ((IEnumerable<string>?)(target.Invoke() as ViewViewComponentResult)?.ViewData?.Model ??
                            Enumerable.Empty<string>()).ToArray();

        // Assert
        Assert.True(First.SequenceEqual(results));
    }

    [Fact]
    public void CanIndicateSelectedCategory() {
        // Arrange
        const string categoryToSelect = "Apples";
        var mock = new Mock<IStoreRepository>();
        mock.Setup(m => m.Products).Returns(new Product[] {
            new() { ProductId = 1, Name = "P1", Category = "Apples" },
            new() { ProductId = 4, Name = "P2", Category = "Oranges" },
        }.AsQueryable());

        var target = new NavigationMenuViewComponent(mock.Object) {
            ViewComponentContext = new ViewComponentContext {
                ViewContext = new ViewContext {
                    RouteData = new Microsoft.AspNetCore.Routing.RouteData()
                }
            }
        };

        target.RouteData.Values["category"] = categoryToSelect;

        // Action
        string? result = (string?)(target.Invoke() as ViewViewComponentResult)?.ViewData?["SelectedCategory"];

        // Assert
        Assert.Equal(categoryToSelect, result);
    }
}