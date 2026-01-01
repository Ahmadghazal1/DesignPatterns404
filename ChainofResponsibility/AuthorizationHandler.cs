namespace ChainofResponsibility;

public class AuthorizationHandler : BaseHandler
{
    public override void Handle(Request request)
    {
        if (!"ADMIN".Equals(request.userRole))
        {
            Console.WriteLine("AuthorizationHandler: ❌ Access denied.");
            return;
        }
        Console.WriteLine("AuthorizationHandler: ✅ Authorized.");
        Forward(request);
    }
}
