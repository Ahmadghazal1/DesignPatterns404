namespace Mediator.Example1;

public abstract class UIComponent
{
    protected IUIMediator mediator;

    public UIComponent(IUIMediator mediator)
    {
        this.mediator = mediator;
    }

    public void NotifyMediator()
    {
        mediator.ComponentChanged(this);
    }
}
