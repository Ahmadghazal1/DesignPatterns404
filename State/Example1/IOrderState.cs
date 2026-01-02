namespace State.Example1;

public interface IOrderState
{
    void Pay();

    void Ship();

    void Deliver();

    void Cancel();
}
