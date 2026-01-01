namespace ChainofResponsibility;

public abstract class BaseHandler : IRequestHandler
{
    protected IRequestHandler next;

    public void SetNext(IRequestHandler next)
    {
       this.next = next;
    }

    protected void Forward(Request request)
    {
        if(next is not null)
        {
            next.Handle(request);
        }
    }

    public abstract void Handle(Request request);
}
