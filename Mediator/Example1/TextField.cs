namespace Mediator.Example1;

public class TextField : UIComponent
{
    private string text = "";

    public TextField(IUIMediator mediator) : base(mediator)
    {
    }

    public void SetText(string newText)
    {
        text = newText;
        Console.WriteLine("TextField updated: " + newText);

        NotifyMediator();
    }

    public string GetText()
    {
        return text;
    }
}
