namespace State;

public class CancelledStateOrder : IOrderState
{
    private readonly Order _order;
    public CancelledStateOrder(Order order)
    {
        _order = order;
    }
    public void Pay()
    {
        Console.WriteLine("not allowed");
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
        Console.WriteLine("not allowed");
    }
}