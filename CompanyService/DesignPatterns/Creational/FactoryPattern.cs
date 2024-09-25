namespace CompanyService.DesignPatterns.Creational;

/*
 Problem: Creating objects directly can lead to tight coupling between client code and concrete classes, making it hard to adapt to changes or extend the system with new classes.

The Factory Pattern solves this by providing an interface to create objects without exposing their concrete implementations.

Solution: The Factory Pattern defines a factory class or method responsible for creating objects. Clients request objects from the factory using a common interface, allowing them to work with abstract types while leaving the concrete object creation to the factory.
 */


// Example: Creating different types of vehicles using a factory
public interface IVehicle
{
    void Drive();
}

public class Car : IVehicle
{
    public void Drive() => Console.WriteLine("Driving a car");
}

public class Bicycle : IVehicle
{
    public void Drive() => Console.WriteLine("Riding a bicycle");
}

public class VehicleFactory
{
    public IVehicle CreateVehicle(string type)
    {
        switch (type)
        {
            case "car": return new Car();
            case "bicycle": return new Bicycle();
            default: throw new ArgumentException("Invalid vehicle type");
        }
    }
}
