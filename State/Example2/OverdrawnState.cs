namespace State.Example2;

public class OverdrawnState : IAccountState
{
    private readonly BankAccount _account;

    public OverdrawnState(BankAccount account)
    {
        _account = account;
    }

    public void Deposit(decimal amount) =>
       Console.WriteLine("Account is closed");

    public void Withdraw(decimal amount) =>
        Console.WriteLine("Account is closed");

    public void Freeze() =>
        Console.WriteLine("Account is closed");

    public void Unfreeze() =>
        Console.WriteLine("Account is closed");

    public void Close() =>
        Console.WriteLine("Account already closed");
}
