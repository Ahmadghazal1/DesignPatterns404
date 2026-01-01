namespace ChainofResponsibility;

public class AuthHandler : BaseHandler
{
    public override void Handle(Request request)
    {
        if (request.user == null)
        {
            Console.WriteLine("AuthHandler: ❌ User not authenticated.");
            return; 
        }
        Console.WriteLine("AuthHandler: ✅ Authenticated.");
        Forward(request);
    }
}
