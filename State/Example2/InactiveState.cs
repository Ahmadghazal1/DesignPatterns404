namespace State.Example2;

public class InactiveState : IAccountState
{
    private readonly BankAccount _bankAccount;

    public InactiveState(BankAccount bankAccount)
    {
        _bankAccount = bankAccount;
    }
    public void Deposit(decimal amount)
    {
        _bankAccount.AddBalance(amount);
        Console.WriteLine("Account activated");
        _bankAccount.ChangeState(new ActiveState(_bankAccount));
    }
    public void Withdraw(decimal amount) =>
        Console.WriteLine("Withdraw not allowed. Account is inactive");

    public void Freeze() =>
        Console.WriteLine("Cannot freeze inactive account");


    public void Unfreeze() =>
         Console.WriteLine("Account is not frozen");


    public void Close()
    {
        Console.WriteLine("Account closed");
        _bankAccount.ChangeState(new ClosedState(_bankAccount));
    }
}
