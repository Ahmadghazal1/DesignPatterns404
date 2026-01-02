namespace State;

public interface IOrderState
{
    void Pay();

    void Ship();

    void Deliver();

    void Cancel();
}
