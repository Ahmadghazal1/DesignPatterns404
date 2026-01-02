namespace State;

public class PaidStateOrder : IOrderState
{
    private readonly Order _order;
    public PaidStateOrder(Order order)
    {
        _order = order;
    }
    public void Pay()
    {
        Console.WriteLine("already paid");
    }

    public void Ship()
    {
        Console.WriteLine("order moves to Shipped");
        _order.ChangeState(new ShippedStateOrder(_order));
    }

    public void Deliver()
    {
        Console.WriteLine("not allowed");
    }

    public void Cancel()
    {
        Console.WriteLine("order moves to Cancelled");
        _order.ChangeState(new CancelledStateOrder(_order));
    }
}
