namespace State.Example2;

public class ActiveState : IAccountState
{
    private readonly BankAccount _bankAccount;

    public ActiveState(BankAccount bankAccount)
    {
        _bankAccount = bankAccount;
    }
    public void Deposit(decimal amount)
    {
        _bankAccount.AddBalance(amount);
        Console.WriteLine($"Deposited {amount}");
    }
    public void Withdraw(decimal amount)
    {
        _bankAccount.SubtractBalance(amount);
        Console.WriteLine($"Withdrew {amount}");
        if (_bankAccount.Balance < 0)
        {
            Console.WriteLine("Account overdrawn");
            _bankAccount.ChangeState(new OverdrawnState(_bankAccount));
        }
    }


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
