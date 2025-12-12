namespace SportsStore.Models;

public interface IOrderRepository {
    IQueryable<Order> Orders { get; }
    public void SaverOrder(Order order);
}