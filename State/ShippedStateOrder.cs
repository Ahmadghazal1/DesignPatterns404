namespace State;

public class ShippedStateOrder : IOrderState
{
    private readonly Order _order;
    public ShippedStateOrder(Order order)
    {
        _order = order;
    }
    public void Pay()
    {
        Console.WriteLine("not allowed");
    }

    public void Ship()
    {
        Console.WriteLine("already shipped");
    }

    public void Deliver()
    {
        Console.WriteLine("order moves to Delivered");
        _order.ChangeState(new DeliveredStateOrder(_order));
    }

    public void Cancel()
    {
        Console.WriteLine("not allowed");
    }
}
