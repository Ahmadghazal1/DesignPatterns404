namespace ChainofResponsibility;

public interface IRequestHandler
{
    void SetNext(IRequestHandler next);
    void Handle(Request request);
}
