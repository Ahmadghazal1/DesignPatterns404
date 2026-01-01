namespace ChainofResponsibility;

public class ValidationHandler : BaseHandler
{
    public override void Handle(Request request)
    {
        if (request.payload == null || request.payload.Trim().Equals(""))
        {
            Console.WriteLine("ValidationHandler: ❌ Invalid payload.");
            return;
        }
        Console.WriteLine("ValidationHandler: ✅ Payload valid.");
        Forward(request);
    }
}
