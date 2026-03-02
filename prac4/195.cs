public class OrderService
{
    public event Action<string> OrderCreated;

    public void CreateOrder(string order)
    {
        OrderCreated?.Invoke(order);
    }
}