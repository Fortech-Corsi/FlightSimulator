namespace CompanyService.DesignPatterns.Structural;

/*
 Problem: Integrating new components or libraries with incompatible interfaces into an existing system can be problematic.

The Adapter Pattern allows these components to work together by creating an adapter that acts as a bridge between the incompatible interfaces.

Solution: The Adapter Pattern defines an adapter class that implements the expected interface for the client code. This adapter class delegates calls to the methods of the adapted object, enabling it to interact with the client code without exposing the incompatible interface.
 */


// Example: Adapting an old printer to a modern interface
public interface IMachine
{
    void Start();
    void Stop();
}

public class OldPrinter
{
    public void PowerOn() => Console.WriteLine("Old printer powered on");
    public void PowerOff() => Console.WriteLine("Old printer powered off");
}

public class PrinterAdapter : IMachine
{
    private readonly OldPrinter _printer;

    public PrinterAdapter(OldPrinter printer)
    {
        _printer = printer;
    }

    public void Start() => _printer.PowerOn();
    public void Stop() => _printer.PowerOff();
}