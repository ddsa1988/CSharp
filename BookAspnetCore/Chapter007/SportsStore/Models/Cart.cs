namespace SportsStore.Models;

public class CartLine {
    public int CartLineId { get; set; }
    public int Quantity { get; set; }
    public Product Product { get; set; } = new();
}

public class Cart {
    public List<CartLine> CartLines { get; set; } = [];

    public virtual void AddItem(Product product, int quantity) {
        CartLine? cartLine = CartLines.FirstOrDefault(cart => cart.Product.ProductId == product.ProductId);

        if (cartLine == null) {
            var newCartLine = new CartLine { Product = product, Quantity = quantity };
            CartLines.Add(newCartLine);
        } else {
            cartLine.Quantity += quantity;
        }
    }

    public virtual void RemoveItem(Product product) {
        CartLines.RemoveAll(cart => cart.Product.ProductId == product.ProductId);
    }

    public decimal ComputeTotalValue() {
        return CartLines.Sum(cart => cart.Product.Price * cart.Quantity);
    }

    public virtual void Clear() {
        CartLines.Clear();
    }
}