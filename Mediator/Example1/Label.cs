namespace Mediator.Example1;

public class Label : UIComponent
{
    private string text;

    public Label(IUIMediator mediator) : base(mediator)
    {
    }

    public void SetText(string message)
    {
        text = message;
        Console.WriteLine("Status: " + text);
    }
}