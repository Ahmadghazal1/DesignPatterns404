namespace State.Example1;

public class Order
{
    private IOrderState _orderState;

    public Order()
    {
        _orderState = new NewStateOrder(this);
    }

    public void ChangeState(IOrderState orderState)
    {
        _orderState = orderState;
    }

    public void Pay()
    {
        _orderState.Pay();
    }

    public void Ship()
    {
        _orderState.Ship();
    }

    public void Deliver()
    {
        _orderState.Deliver();

    }

    public void Cancel()
    {
        _orderState.Cancel();

    }
}
