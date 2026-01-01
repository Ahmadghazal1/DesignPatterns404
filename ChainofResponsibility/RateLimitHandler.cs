namespace ChainofResponsibility;

public class RateLimitHandler : BaseHandler
{
    public override void Handle(Request request)
    {
        if (request.requestCount >= 100)
        {
            Console.WriteLine("RateLimitHandler: ❌ Rate limit exceeded.");
            return;
        }
        Console.WriteLine("RateLimitHandler: ✅ Within rate limit.");
        Forward(request);
    }
}
