namespace Mediator.Example2;

public class Airplane
{
    private string _name;
    private IAirTrafficControl _airTrafficControl;

    public Airplane(string name , IAirTrafficControl airTrafficControl)
    {
        _name = name;
        _airTrafficControl = airTrafficControl;
    }

    public void RequestTakeoff()
    {
        Console.WriteLine($"{_name} requests takeoff.");
        _airTrafficControl.RequestTakeoff(this);
    }

    public void RequestLanding()
    {
        Console.WriteLine($"{_name} requests landing.");
        _airTrafficControl.RequestLanding(this);
    }

    public void ReceiveStatus(string status)
    {
        Console.WriteLine($"{_name} received status: {status}");
    }
    public string GetName => _name;
}
