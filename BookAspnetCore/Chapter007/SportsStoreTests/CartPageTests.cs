using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Moq;
using SportsStore.Models;
using SportsStore.Pages;
using Cart = SportsStore.Models.Cart;

namespace SportsStoreTests;

public class CartPageTests {
    [Fact]
    public void CanLoadCart() {
        // Arrange

        // Create a mock repository
        var p1 = new Product { ProductId = 1, Name = "P1" };
        var p2 = new Product { ProductId = 2, Name = "P2" };
        var mockRepository = new Mock<IStoreRepository>();
        mockRepository.Setup(repository => repository.Products).Returns((new[] { p1, p2 }).AsQueryable());

        // Create a cart
        var testCart = new Cart();
        testCart.AddItem(p1, 2);
        testCart.AddItem(p2, 1);

        // Create a mock page context and session
        var mockSession = new Mock<ISession>();
        byte[]? data = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(testCart));
        mockSession.Setup(session => session.TryGetValue(It.IsAny<string>(), out data));

        var mockContext = new Mock<HttpContext>();
        mockContext.Setup(context => context.Session).Returns(mockSession.Object);

        // Act
        var cartModel = new CartModel(mockRepository.Object) {
            PageContext = new PageContext(new ActionContext() {
                HttpContext = mockContext.Object,
                RouteData = new RouteData(),
                ActionDescriptor = new PageActionDescriptor(),
            })
        };

        cartModel.OnGet("myUrl");

        // Assert
        Assert.Equal(2, cartModel.Cart?.CartLines.Count);
        Assert.Equal("myUrl", cartModel.ReturnUrl);
    }

    [Fact]
    public void CanUpdateCart() { }
}