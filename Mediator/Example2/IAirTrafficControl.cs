namespace Mediator.Example2;

public interface IAirTrafficControl
{
    void RequestTakeoff(Airplane airplane);
    void RequestLanding(Airplane airplane);
    void NotifyRunwayStatus(string status , Airplane airplane);
}
