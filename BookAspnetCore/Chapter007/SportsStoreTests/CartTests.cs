using SportsStore.Models;

namespace SportsStoreTests;

public class CartTests {
    [Fact]
    public void CanAddItemToCart() {
        // Arrange
        var p1 = new Product { ProductId = 1, Name = "P1" };
        var p2 = new Product { ProductId = 2, Name = "P2" };
        var cart = new Cart();

        // Act
        cart.AddItem(p1, 1);
        cart.AddItem(p2, 1);

        CartLine[] cartLines = cart.CartLines.ToArray();

        // Assert
        Assert.Equal(2, cartLines.Length);
        Assert.Equal(p1, cartLines[0].Product);
        Assert.Equal(p2, cartLines[1].Product);
    }

    [Fact]
    public void CanAddQuantityToItemInTheCart() {
        // Arrange
        var p1 = new Product { ProductId = 1, Name = "P1" };
        var p2 = new Product { ProductId = 2, Name = "P2" };
        var cart = new Cart();

        // Act
        cart.AddItem(p1, 1);
        cart.AddItem(p2, 1);
        cart.AddItem(p1, 10);

        CartLine[] cartLines = cart.CartLines.ToArray();

        // Assert
        Assert.Equal(2, cartLines.Length);
        Assert.Equal(11, cartLines[0].Quantity);
        Assert.Equal(1, cartLines[1].Quantity);
    }

    [Fact]
    public void CanRemoveItemFromCart() {
        // Arrange
        var p1 = new Product { ProductId = 1, Name = "P1" };
        var p2 = new Product { ProductId = 2, Name = "P2" };
        var p3 = new Product { ProductId = 3, Name = "P3" };
        var cart = new Cart();

        // Act
        cart.AddItem(p1, 1);
        cart.AddItem(p2, 3);
        cart.AddItem(p3, 5);
        cart.AddItem(p2, 1);
        cart.RemoveItem(p2);

        CartLine[] cartLines = cart.CartLines.ToArray();

        // Assert
        Assert.Empty(cartLines.Where(cartLine => cartLine.Product == p2));
        Assert.Equal(2, cartLines.Length);
    }

    [Fact]
    public void CanComputeTotalValue() {
        // Arrange
        var p1 = new Product { ProductId = 1, Name = "P1", Price = 100M };
        var p2 = new Product { ProductId = 2, Name = "P2", Price = 50M };
        var cart = new Cart();

        // Act
        cart.AddItem(p1, 1);
        cart.AddItem(p2, 1);
        cart.AddItem(p1, 3);

        decimal total = cart.ComputeTotalValue();

        // Assert
        Assert.Equal(450M, total);
    }

    [Fact]
    public void CanClearContent() {
        // Arrange
        var p1 = new Product { ProductId = 1, Name = "P1", Price = 100M };
        var p2 = new Product { ProductId = 2, Name = "P2", Price = 50M };
        var cart = new Cart();

        // Act
        cart.AddItem(p1, 1);
        cart.AddItem(p2, 1);
        cart.Clear();

        // Assert
        Assert.Empty(cart.CartLines);
    }
}