namespace ChainofResponsibility;

public class Request
{
    public string user;
    public string userRole;
    public int requestCount;
    public string payload;

    public Request(string user, string userRole, int requestCount, string payload)
    {
        this.user = user;
        this.userRole = userRole;
        this.requestCount = requestCount;
        this.payload = payload;
    }
}
