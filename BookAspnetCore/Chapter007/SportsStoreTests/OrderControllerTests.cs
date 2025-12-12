using Microsoft.AspNetCore.Mvc;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;

namespace SportsStoreTests;

public class OrderControllerTests {
    [Fact]
    public void CannotCheckoutEmptyCart() {
        // Arrange
        var mock = new Mock<IOrderRepository>();
        var cart = new Cart();
        var order = new Order();
        var controller = new OrderController(mock.Object, cart);

        // Act
        var result = controller.Checkout(order) as ViewResult;

        // Assert

        // Check that the order hasn't been stored
        mock.Verify(orderRepository => orderRepository.SaverOrder(It.IsAny<Order>()), Times.Never);

        // Check that the method is returning the default view
        Assert.True(string.IsNullOrEmpty(result?.ViewName));

        // Check that I am passing an invalid model to the view
        Assert.False(result?.ViewData.ModelState.IsValid);
    }

    [Fact]
    public void CannotCheckoutInvalidShippingDetails() {
        // Arrange

        // Act

        // Assert
    }

    [Fact]
    public void CanCheckoutAndSubmitOrder() {
        // Arrange

        // Act

        // Assert
    }
}