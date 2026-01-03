namespace Mediator.Example1;

public class Button : UIComponent
{
    private bool enabled = false;

    public Button(IUIMediator mediator) : base(mediator)
    {
    }

    public void Click()
    {
        if(enabled)
        {
            Console.WriteLine("Login Button clicked!");
            NotifyMediator(); // Will trigger login attempt
        }
        else
        {
            Console.WriteLine("Login Button is disabled.");
        }
    }

    public void SetEnabled(bool value)
    {
        enabled = value;
        Console.WriteLine("Login Button is now " + (enabled ? "ENABLED" : "DISABLED"));
    }
}
