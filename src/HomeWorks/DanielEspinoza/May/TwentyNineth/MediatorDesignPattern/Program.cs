namespace MediatorDesignPattern;
public interface IControlTowerMediator
{
    void SendMessage(string message, string aircraftId);
    void AddAircraft(Aircraft aircraft);
}

public class ControlTower : IControlTowerMediator
{
    private readonly Dictionary<string, Aircraft> _aircrafts = new Dictionary<string, Aircraft>();

    public void AddAircraft(Aircraft aircraft)
    {
        if (!_aircrafts.ContainsKey(aircraft.Id))
        {
            _aircrafts.Add(aircraft.Id, aircraft);
            aircraft.SetControlTower(this);
        }
    }

    public void SendMessage(string message, string aircraftId)
    {
        if (_aircrafts.ContainsKey(aircraftId))
        {
            _aircrafts[aircraftId].Receive(message);
        }
    }
}

public abstract class Aircraft
{
    protected IControlTowerMediator controlTower;
    public string Id { get; private set; }
    public string Name { get; private set; }

    public Aircraft(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public void SetControlTower(IControlTowerMediator controlTower)
    {
        this.controlTower = controlTower;
    }

    public abstract void Send(string message, string aircraftId);
    public abstract void Receive(string message);
}

public class PassengerAircraft(string id, string name) : Aircraft(id, name)
{
    public override void Send(string message, string aircraftId)
    {
        Console.WriteLine($"{Name} (ID: {Id}) sends message: '{message}' to Aircraft ID: {aircraftId}");
        controlTower.SendMessage(message, aircraftId);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{Name} (ID: {Id}) receives message: '{message}'");
    }
}

public class CargoAircraft(string id, string name) : Aircraft(id, name)
{
    public override void Send(string message, string aircraftId)
    {
        Console.WriteLine($"{Name} (ID: {Id}) sends message: '{message}' to Aircraft ID: {aircraftId}");
        controlTower.SendMessage(message, aircraftId);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{Name} (ID: {Id}) receives message: '{message}'");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IControlTowerMediator controlTower = new ControlTower();

        Aircraft passengerAircraft1 = new PassengerAircraft("PA123", "Passenger Aircraft 1");
        Aircraft cargoAircraft = new CargoAircraft("CA456", "Cargo Aircraft 1");
        Aircraft passengerAircraft2 = new PassengerAircraft("PA789", "Passenger Aircraft 2");

        controlTower.AddAircraft(passengerAircraft1);
        controlTower.AddAircraft(cargoAircraft);
        controlTower.AddAircraft(passengerAircraft2);

        passengerAircraft1.Send("Requesting permission to land.", "CA456");
        cargoAircraft.Send("Permission granted. Clear to land on runway 2.", "PA123");
        passengerAircraft2.Send("Requesting taxi clearance to runway 1.", "PA123");

        passengerAircraft1.Send("Landed on runway 2. Requesting taxi to gate 3.", "CA456");
        cargoAircraft.Send("Cargo unloaded. Ready for next flight.", "PA123");
        passengerAircraft2.Send("Cleared runway 1. Requesting gate assignment.", "CA456");
    }
}
