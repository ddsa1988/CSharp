using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models;

public class EfOrderRepository : IOrderRepository {
    private StoreDbContext _context;

    public EfOrderRepository(StoreDbContext context) {
        _context = context;
    }

    public IQueryable<Order> Orders =>
        _context.Orders.Include(order => order.CartLines).ThenInclude(cartLine => cartLine.Product);

    public void SaverOrder(Order order) {
        _context.AttachRange(order.CartLines.Select(orderLine => orderLine.Product));

        if (order.CartLines.Count == 0) return;

        _context.Orders.Add(order);
        _context.SaveChanges();
    }
}