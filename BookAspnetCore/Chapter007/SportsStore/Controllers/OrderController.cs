using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers;

public class OrderController : Controller {
    private readonly IOrderRepository _orderRepository;
    private readonly Cart _cart;

    public OrderController(IOrderRepository orderRepository, Cart cart) {
        _orderRepository = orderRepository;
        _cart = cart;
    }

    [HttpGet]
    public ViewResult Checkout() {
        return View(new Order());
    }

    [HttpPost]
    public IActionResult Checkout(Order order) {
        if (_cart.CartLines.Count == 0) {
            ModelState.AddModelError("", "Sorry, your cart is empty!");
        }

        if (!ModelState.IsValid) return View();

        order.CartLines = _cart.CartLines.ToArray();
        _orderRepository.SaverOrder(order);
        _cart.Clear();

        return RedirectToPage("/Completed", new { order.OrderId });
    }
}