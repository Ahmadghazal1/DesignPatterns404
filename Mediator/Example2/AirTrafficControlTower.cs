namespace Mediator.Example2;
public class AirTrafficControlTower : IAirTrafficControl
{
    private bool _isRunwayFree = true;
    private List<Airplane> _planes = new List<Airplane>();

    public void RegisterPlane(Airplane plane)
    {
        _planes.Add(plane);
    }

    public void RequestTakeoff(Airplane airplane)
    {
        if (_isRunwayFree)
        {
            Console.WriteLine($"Runway is free. {airplane.GetName} can take off.");
            _isRunwayFree = false;
            NotifyRunwayStatus($"{airplane.GetName} is taking off." , airplane);
            _isRunwayFree = true;
        }
        else
        {
            Console.WriteLine($"Runway is busy. {airplane.GetName} must wait to take off.");
        }
    }

    public void RequestLanding(Airplane airplane)
    {
        if (_isRunwayFree)
        {
            Console.WriteLine($"Runway is free. {airplane.GetName} can land.");
            _isRunwayFree = false;
            NotifyRunwayStatus($"{airplane.GetName} is landing." , airplane);
            _isRunwayFree = true;
        }
        else
        {
            Console.WriteLine($"Runway is busy. {airplane.GetName} must wait to land.");
        }
    }

    public void NotifyRunwayStatus(string status , Airplane airplane)
    {
        foreach (var plane in _planes)
        {
            if(airplane.GetName != plane.GetName)
                plane.ReceiveStatus(status);
        }
    }

}
