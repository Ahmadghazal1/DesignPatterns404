namespace State;

public class NewStateOrder : IOrderState
{
    private readonly Order _order;
    public NewStateOrder(Order order)
    {
        _order = order;
    }

    public void Pay()
    {
        Console.WriteLine("order moves to Paid");
        _order.ChangeState(new PaidStateOrder(_order));
    }

    public void Ship()
    {
        Console.WriteLine("not allowed");
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
