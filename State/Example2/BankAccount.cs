namespace State.Example2;

public class BankAccount
{
    public decimal Balance { get; private set; }

    private IAccountState _state;
    public BankAccount()
    {
        _state = new InactiveState(this);
    }
    public void ChangeState(IAccountState newState)
    {
        _state = newState;
    }
    public void AddBalance(decimal amount) => Balance += amount;
    public void SubtractBalance(decimal amount) => Balance -= amount;


}
