namespace State.Example2;

public interface IAccountState
{
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
    void Freeze();
    void Unfreeze();
    void Close();
}
