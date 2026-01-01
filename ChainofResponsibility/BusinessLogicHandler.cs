namespace ChainofResponsibility;

public class BusinessLogicHandler : BaseHandler
{
    public override void Handle(Request request)
    {
        Console.WriteLine("BusinessLogicHandler: 🚀 Processing request...");
        // Core application logic goes here
    }
}
